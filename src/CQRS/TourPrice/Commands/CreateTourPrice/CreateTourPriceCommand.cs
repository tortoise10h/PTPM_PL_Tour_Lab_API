using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Helpers;
using src.Services;
using E = src.Entities;

namespace src.CQRS.TourPrice.Commands.CreateTourPrice
{
    public class CreateTourPriceCommand : IRequest<Result<TourPriceResponse>>
    {
        public int TourId { get; set; }
        public long Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class CreateTourPriceHandler : IRequestHandler<CreateTourPriceCommand, Result<TourPriceResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ITourPricesService _tourPricesService;

        public CreateTourPriceHandler(DataContext context, IMapper mapper, ITourPricesService tourPricesService = null)
        {
            _context = context;
            _mapper = mapper;
            _tourPricesService = tourPricesService;
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
                        new ApiError("Tour does not exist"))
                );
            }

            /** Do not allow start date and end date conflict */
            var checkConflictResult = await this._tourPricesService.CheckConflictDateWhenCreate(request.TourId, request.StartDate, request.EndDate);

            if (!checkConflictResult.Equals(""))
            {
                return new Result<TourPriceResponse>(
                    new BadRequestException(
                        new ApiError(checkConflictResult))
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
                    new ApiError("Thêm giá tour thất bại, vui lòng thử lại"))
            );
        }
    }
}