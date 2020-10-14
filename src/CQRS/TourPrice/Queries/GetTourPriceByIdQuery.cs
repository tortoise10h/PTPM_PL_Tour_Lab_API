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

namespace src.CQRS.TourPrice.Queries
{
    public class GetTourPriceById : IRequest<Result<TourPriceResponse>>
    {
        public GetTourPriceById(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
    }

    public class GetTourPriceByIdHandler : IRequestHandler<GetTourPriceById, Result<TourPriceResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetTourPriceByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourPriceResponse>> Handle(GetTourPriceById request, CancellationToken cancellationToken)
        {
            var tourPrice = await _context.TourPrice.SingleOrDefaultAsync(
                ta => ta.Id == request.Id &&
                ta.IsDeleted == false
            );

            if (tourPrice == null)
            {
                return new Result<TourPriceResponse>(
                    new NotFoundException()
                );
            }

            return new Result<TourPriceResponse>(
                _mapper.Map<TourPriceResponse>(tourPrice)
            );
        }
    }
}
