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

namespace src.CQRS.CostType.Commands.DeleteCostType
{
    public class DeleteCostTypeCommand : IRequest<Result<CostTypeResponse>>
    {
        public int Id { get; set; }

        public DeleteCostTypeCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteCostTypeHandler : IRequestHandler<DeleteCostTypeCommand, Result<CostTypeResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteCostTypeHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<CostTypeResponse>> Handle(DeleteCostTypeCommand request, CancellationToken cancellationToken)
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

            var costTypeInGroupCost = await _context.GroupCost.FirstOrDefaultAsync(
                gc => gc.CostTypeId == request.Id
            );

            if (costTypeInGroupCost != null)
            {
                return new Result<CostTypeResponse>(
                    new BadRequestException(new ApiError("Không thể xoá loại chi phí đã được áp dụng vào đoàn"))
                );
            }

            costType.IsDeleted = true;
            _context.CostType.Update(costType);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<CostTypeResponse>(
                    _mapper.Map<CostTypeResponse>(costType)
                );
            }

            return new Result<CostTypeResponse>(
                new BadRequestException(new ApiError("Xoá loại chi phí thất bại, vui lòng thử lại"))
            );
        }
    }
}