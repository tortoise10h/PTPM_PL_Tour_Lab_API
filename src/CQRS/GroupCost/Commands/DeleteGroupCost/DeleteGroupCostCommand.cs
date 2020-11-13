using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupCost;
using src.Helpers;

namespace src.CQRS.GroupCost.Commands.DeleteGroupCost
{
    public class DeleteGroupCostCommand : IRequest<Result<GroupCostResponse>>
    {

        public DeleteGroupCostCommand(int id)
        {
            this.Id = id;
        }
        public int Id { get; set; }
    }

    public class DeleteGroupCostHandler : IRequestHandler<DeleteGroupCostCommand, Result<GroupCostResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteGroupCostHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupCostResponse>> Handle(DeleteGroupCostCommand request, CancellationToken cancellationToken)
        {
            var groupCost = await _context.GroupCost.SingleOrDefaultAsync(
                gc => gc.Id == request.Id &&
                gc.IsDeleted == false
            );

            if (groupCost == null)
            {
                return new Result<GroupCostResponse>(
                    new NotFoundException()
                );
            }

            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == groupCost.GroupId
            );

            if (group.Status != GroupStatusEnum.New)
            {
                return new Result<GroupCostResponse>(
                    new BadRequestException(
                        new ApiError("Chỉ có thể xoá khi trạng thái của đoàn là Mới")
                    )
                );
            }

            _context.GroupCost.Remove(groupCost);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<GroupCostResponse>(
                    _mapper.Map<GroupCostResponse>(groupCost)
                );
            }

            return new Result<GroupCostResponse>(
                new BadRequestException(new ApiError("Xoá chi phí đoàn thất bại, vui lòng thử lại"))
            );
        }
    }
}