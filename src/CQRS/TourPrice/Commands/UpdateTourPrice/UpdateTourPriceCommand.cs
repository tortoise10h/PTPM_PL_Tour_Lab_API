using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TouristAttraction;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Helpers;
using src.Services;
using E = src.Entities;

namespace src.CQRS.TourPrice.Commands.CreateTourPrice
{
    public class UpdateTourPriceCommand : IRequest<Result<TourPriceResponse>>
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class UpdateTourPriceHandler : IRequestHandler<UpdateTourPriceCommand, Result<TourPriceResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ITourPricesService _tourPricesService;

        public UpdateTourPriceHandler(DataContext context, IMapper mapper, ITourPricesService tourPricesService = null)
        {
            _context = context;
            _mapper = mapper;
            _tourPricesService = tourPricesService;
        }
        public async Task<Result<TourPriceResponse>> Handle(UpdateTourPriceCommand request, CancellationToken cancellationToken)
        {
            var tourPrice = await _context.TourPrice
                .Where(
                    tp => tp.Id == request.Id &&
                    tp.IsDeleted != true
                )
                .Include(tp => tp.Tour)
                .FirstOrDefaultAsync();

            if (tourPrice == null)
            {
                return new Result<TourPriceResponse>(
                    new NotFoundException()
                );
            }

            /** Make sure when update we don't cause the conflict date between each
             * tour price */
            string checkConflictDateResult = await this._tourPricesService.CheckConflictDateWhenUpdate(tourPrice.TourId, tourPrice.Id, request.StartDate, request.EndDate);
            if (!checkConflictDateResult.Equals(""))
            {
                return new Result<TourPriceResponse>(
                    new BadRequestException(new ApiError(checkConflictDateResult))
                );
            }

            /** If which groups relate to this tour price (group which has the start date between
            * the start date and end date of tour price) and haven't started yet (status: New)
            * so check them all again and update correct price for them
            */
            var effectedGroups = await _tourPricesService.ListGroupAreChangedWhenUpdateTourPrice(
                tourPrice.StartDate, tourPrice.EndDate,
                request.StartDate, request.EndDate,
                tourPrice.Tour.Price, tourPrice.TourId);

            _mapper.Map<UpdateTourPriceCommand, E.TourPrice>(request, tourPrice);


            _context.TourPrice.Update(tourPrice);
            if (effectedGroups.Count > 0)
            {
                _context.Group.UpdateRange(effectedGroups);
            }
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<TourPriceResponse>(
                    _mapper.Map<TourPriceResponse>(tourPrice)
                );
            }

            return new Result<TourPriceResponse>(
                new BadRequestException(new ApiError("Update tourist attraction failed, please try again"))
            );
        }
    }
}
