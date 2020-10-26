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
using E = src.Entities;

namespace src.CQRS.CostType.Commands.UpdateCostType
{
    public class UpdateCostTypeCommand : IRequest<Result<CostTypeResponse>>
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }

    public class UpdateCostTypeHandler : IRequestHandler<UpdateCostTypeCommand, Result<CostTypeResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateCostTypeHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<CostTypeResponse>> Handle(UpdateCostTypeCommand request, CancellationToken cancellationToken)
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

            _mapper.Map<UpdateCostTypeCommand, E.CostType>(request, costType);
            _context.CostType.Update(costType);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<CostTypeResponse>(
                    _mapper.Map<CostTypeResponse>(costType)
                );
            }

            return new Result<CostTypeResponse>(
                new BadRequestException(new ApiError("Update Cost Type failed, please try again"))
            );
        }
    }
}