using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Helpers;

namespace src.CQRS.TourPrice.Commands.DeleteTourPrice
{
    public class DeleteTourPriceCommand : IRequest<Result<TourPriceResponse>>
    {
        public int Id { get; set; }
        public DeleteTourPriceCommand(int tourPriceId)
        {
            Id = tourPriceId;
        }
    }

    public class DeleteTourPriceHandler : IRequestHandler<DeleteTourPriceCommand, Result<TourPriceResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public DeleteTourPriceHandler(DataContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TourPriceResponse>> Handle(DeleteTourPriceCommand request, CancellationToken cancellationToken)
        {
            var tourPrice = await _context.TourPrice.SingleOrDefaultAsync(
                tp => tp.Id == request.Id &&
                tp.IsDeleted != true
            );

            if (tourPrice == null)
            {
                return new Result<TourPriceResponse>(
                    new NotFoundException()
                );
            }

            tourPrice.IsDeleted = true;
            _context.TourPrice.Update(tourPrice);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<TourPriceResponse>(
                    _mapper.Map<TourPriceResponse>(tourPrice)
                );
            }
            return new Result<TourPriceResponse>(
                new BadRequestException(new ApiError("Xoá giá tour thất bại, vui lòng thử lại"))
            );
        }
    }
}
