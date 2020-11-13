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

namespace src.CQRS.GroupCost.Commands.CreateGroupCost
{
    public class CreateGroupCostCommand : IRequest<Result<GroupCostResponse>>
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int CostTypeId { get; set; }
        public long Price { get; set; }
        public string Note { get; set; }
    }

    public class CreateGroupCostHandler : IRequestHandler<CreateGroupCostCommand, Result<GroupCostResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateGroupCostHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupCostResponse>> Handle(CreateGroupCostCommand request, CancellationToken cancellationToken)
        {
            /** Make sure GroupId exist and status is New or Processing **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.GroupId
            );

            if (group == null)
            {
                return new Result<GroupCostResponse>(
                    new BadRequestException(
                        new ApiError("Đoàn không tồn tại")
                    )
                );
            }
            if (group.Status != GroupStatusEnum.New)
            {
                return new Result<GroupCostResponse>(
                    new BadRequestException(
                        new ApiError("Chỉ có thể thêm khi trạng thái của đoàn là Mới")
                    )
                );
            }

            var costType = await _context.CostType.SingleOrDefaultAsync(
                ct => ct.Id == request.CostTypeId
            );

            if (costType == null)
            {
                return new Result<GroupCostResponse>(
                    new BadRequestException(
                        new ApiError("Loại chi phí không tồn tại")
                    )
                );
            }

            var groupCost = _mapper.Map<E.GroupCost>(request);

            await _context.GroupCost.AddAsync(groupCost);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<GroupCostResponse>(
                    _mapper.Map<GroupCostResponse>(groupCost)
                );
            }

            return new Result<GroupCostResponse>(
                new BadRequestException(new ApiError("Thêm chi phí đoàn thất bại, vui lòng thử lại"))
            );
        }
    }
}