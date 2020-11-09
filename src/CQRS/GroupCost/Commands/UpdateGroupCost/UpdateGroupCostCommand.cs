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
using E = src.Entities;

namespace src.CQRS.GroupCost.Commands.UpdateGroupCost
{
    public class UpdateGroupCostCommand : IRequest<Result<GroupCostResponse>>
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string Note { get; set; }
    }

    public class UpdateGroupCostCommandHandler : IRequestHandler<UpdateGroupCostCommand, Result<GroupCostResponse>>
    {
        private readonly DataContext _context;

        private readonly IMapper _mapper;
        public UpdateGroupCostCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupCostResponse>> Handle(UpdateGroupCostCommand request, CancellationToken cancellationToken)
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

            if (group.Status != GroupStatusEnum.New && group.Status != GroupStatusEnum.Processing)
            {
                return new Result<GroupCostResponse>(
                    new BadRequestException(
                        new ApiError("Chỉ có thể sửa khi trạng thái của đoàn là Mới và Đang Khởi Hành")
                    )
                );
            }

            _mapper.Map<UpdateGroupCostCommand, E.GroupCost>(request, groupCost);

            _context.GroupCost.Update(groupCost);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GroupCostResponse>(
                    _mapper.Map<GroupCostResponse>(groupCost)
                );
            }

            return new Result<GroupCostResponse>(
                new BadRequestException(new ApiError("Sửa chi phí đoàn thất bại, vui lòng thử lại"))
            );
        }
    }
}