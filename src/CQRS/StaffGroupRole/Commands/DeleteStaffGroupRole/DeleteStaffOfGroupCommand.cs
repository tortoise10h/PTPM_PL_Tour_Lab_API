using System.Collections.Generic;
using System.Linq;
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
    public class DeleteStaffOfGroupCommand : IRequest<Result<List<StaffGroupRoleResponse>>>
    {
        public int GroupId { get; set; }
        public string StaffId { get; set; }
    }

    public class DeleteStaffOfGroupHandler : IRequestHandler<DeleteStaffOfGroupCommand, Result<List<StaffGroupRoleResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteStaffOfGroupHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<StaffGroupRoleResponse>>> Handle(DeleteStaffOfGroupCommand request, CancellationToken cancellationToken)
        {
            var staffGroupRole = await _context.StaffGroupRole
                .Where(
                    sgr => sgr.StaffId == request.StaffId &&
                    sgr.GroupId == request.GroupId)
                .ToListAsync();

            if (!(staffGroupRole.Count() > 0))
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new NotFoundException()
                );
            }

            /** Make sure GroupStatus is New **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.GroupId
                && g.IsDeleted == false
            );

            if (group.Status != GroupStatusEnum.New && group.Status != GroupStatusEnum.Processing)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Can't delete Staff when group status is not New and Processing")
                    )
                );
            }

            _context.StaffGroupRole.RemoveRange(staffGroupRole);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    _mapper.Map<List<StaffGroupRoleResponse>>(staffGroupRole)
                );
            }

            return new Result<List<StaffGroupRoleResponse>>(
                new BadRequestException(new ApiError("Delete Staff from Group failed, please try again"))
            );
        }
    }
}