using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.CostType;
using src.Helpers;

namespace src.CQRS.CostType.Queries
{
    public class GetCostTypeByIdQuery : IRequest<Result<CostTypeResponse>>
    {
        public Guid Id { get; set; }

        public GetCostTypeByIdQuery(Guid id)
        {
            Id = id;
        }
    }

    public class GetCostTypeByIdHandler : IRequestHandler<GetCostTypeByIdQuery, Result<CostTypeResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetCostTypeByIdHandler(DataContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<CostTypeResponse>> Handle(GetCostTypeByIdQuery request, CancellationToken cancellationToken)
        {
            var costType = await _context.CostType.SingleOrDefaultAsync(
                ct => ct.Id == request.Id &&
                ct.IsDeleted == false
            );

            if (costType == null)
            {
                return new Result<CostTypeResponse>(
                    new NotFoundException()
                );
            }

            return new Result<CostTypeResponse>(
                _mapper.Map<CostTypeResponse>(costType)
            );
        }
    }
}