using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Tour;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.TourPrice.Commands.CreateTourPrice
{
    public class CreateTourPriceCommand : IRequest<Result<TourPriceResponse>>
    {
        public string TourId { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class CreateTourPriceHandler : IRequestHandler<CreateTourPriceCommand, Result<TourPriceResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateTourPriceHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourPriceResponse>> Handle(
            CreateTourPriceCommand request,
            CancellationToken cancellationToken)
        {
            var tourPriceEntity = _mapper.Map<E.TourPrice>(request);

            /** Make sure tour of tour price is existed */
            var tour = await _context.Tours
                .SingleOrDefaultAsync(
                    t => t.Id == tourPriceEntity.TourId &&
                    t.IsDeleted != true);
            if (tour == null)
            {
                return new Result<TourPriceResponse>(
                    new BadRequestException(
                        new ApiError("tour is not existed (tourId)"))
                );
            }

            /** Do not allow start date and end date conflict */
            var conflictDateTourPrice = await _context.TourPrice
                .SingleOrDefaultAsync(tp =>
                    tp.TourId == Guid.Parse(request.TourId) &&
                    tp.IsDeleted == false &&
                    tp.StartDate <= request.StartDate && tp.EndDate >= request.StartDate ||
                    tp.StartDate <= request.EndDate && tp.EndDate >= request.EndDate);
            if (conflictDateTourPrice != null)
            {
                return new Result<TourPriceResponse>(
                    new BadRequestException(
                        new ApiError($"Duplicate tour price in date range between [{request.StartDate.ToString()}] - [{request.EndDate.ToString()}]")
                    )
                );
            }

            await _context.TourPrice.AddAsync(tourPriceEntity);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<TourPriceResponse>(
                    _mapper.Map<TourPriceResponse>(tourPriceEntity)
                );
            }

            return new Result<TourPriceResponse>(
                new BadRequestException(
                    new ApiError("Create tour price failed, please try again"))
            );
        }
    }
}