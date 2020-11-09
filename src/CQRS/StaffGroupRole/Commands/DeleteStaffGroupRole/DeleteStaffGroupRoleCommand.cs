using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.StaffGroupRole;
using src.Helpers;

namespace src.CQRS.StaffGroupRole.Commands.DeleteStaffGroupRole
{
    public class DeleteStaffGroupRoleCommand : IRequest<Result<StaffGroupRoleResponse>>
    {
        public DeleteStaffGroupRoleCommand(int id)
        {
            this.Id = id;
        }
        public int Id { get; set; }
    }

    public class DeleteStaffGroupRoleHandler : IRequestHandler<DeleteStaffGroupRoleCommand, Result<StaffGroupRoleResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteStaffGroupRoleHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<StaffGroupRoleResponse>> Handle(DeleteStaffGroupRoleCommand request, CancellationToken cancellationToken)
        {
            var staffGroupRole = await _context.StaffGroupRole.SingleOrDefaultAsync(
                sgr => sgr.Id == request.Id
            );

            if (staffGroupRole == null)
            {
                return new Result<StaffGroupRoleResponse>(
                    new NotFoundException()
                );
            }

            /** Make sure GroupStatus is New **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == staffGroupRole.GroupId
                && g.IsDeleted == false
            );

            if (group.Status != GroupStatusEnum.New && group.Status != GroupStatusEnum.Processing)
            {
                return new Result<StaffGroupRoleResponse>(
                    new BadRequestException(
                        new ApiError("Chỉ có thể xoá khi trạng thái của đoàn là Mới và Đang Khởi Hành")
                    )
                );
            }

            _context.StaffGroupRole.Remove(staffGroupRole);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<StaffGroupRoleResponse>(
                    _mapper.Map<StaffGroupRoleResponse>(staffGroupRole)
                );
            }

            return new Result<StaffGroupRoleResponse>(
                new BadRequestException(new ApiError("Xoá công việc thất bại, vui lòng thử lại"))
            );
        }
    }
}