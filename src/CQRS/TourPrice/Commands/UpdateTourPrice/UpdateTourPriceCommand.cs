using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
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
        public Guid Id { get; set; }
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
            var tourPrice = await _context.TourPrice.SingleOrDefaultAsync(
                ta => ta.Id == request.Id &&
                ta.IsDeleted != true
            );

            if (tourPrice == null)
            {
                return new Result<TourPriceResponse>(
                    new NotFoundException()
                );
            }

            _mapper.Map<UpdateTourPriceCommand, E.TourPrice>(request, tourPrice);

            string checkConflictDateResult = await this._tourPricesService.IsTourPriceDateConflict(tourPrice.TourId, tourPrice.Id, tourPrice.StartDate, tourPrice.EndDate);
            
            if (!checkConflictDateResult.Equals(""))
            {
                return new Result<TourPriceResponse>(
                    new BadRequestException(new ApiError(checkConflictDateResult))
                );
            }

            _context.TourPrice.Update(tourPrice);
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
