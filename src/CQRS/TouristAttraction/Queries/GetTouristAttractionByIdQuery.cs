using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TouristAttraction;
using src.Helpers;

namespace src.CQRS.TouristAttraction.Queries
{
    public class GetTouristAttractionByIdQuery : IRequest<Result<TouristAttractionResponse>>
    {
        public GetTouristAttractionByIdQuery(Guid id)
        {
            this.Id = id;

        }
        public Guid Id { get; set; }
    }

    public class GetTouristAttractionByIdHandler : IRequestHandler<GetTouristAttractionByIdQuery, Result<TouristAttractionResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetTouristAttractionByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TouristAttractionResponse>> Handle(GetTouristAttractionByIdQuery request, CancellationToken cancellationToken)
        {
            var touristAttraction = await _context.TouristAttraction.SingleOrDefaultAsync(
                ta => ta.Id == request.Id &&
                ta.IsDeleted == false
            );

            if (touristAttraction == null)
            {
                return new Result<TouristAttractionResponse>(
                    new NotFoundException()
                );
            }

            return new Result<TouristAttractionResponse>(
                _mapper.Map<TouristAttractionResponse>(touristAttraction)
            );
        }
    }
}