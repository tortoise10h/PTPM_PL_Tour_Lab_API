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
using Microsoft.AspNetCore.Identity;
using E = src.Entities;
using src.Entities;

namespace src.CQRS.StaffGroupRole.Commands.CreateStaffGroupRole
{
    public class CreateStaffGroupRoleCommand : IRequest<Result<StaffGroupRoleResponse>>
    {
        public string StaffId { get; set; }
        public int GroupId { get; set; }
        public int GroupRoleId { get; set; }
    }

    public class CreateStaffGroupRoleHandler : IRequestHandler<CreateStaffGroupRoleCommand, Result<StaffGroupRoleResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateStaffGroupRoleHandler(DataContext context, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Result<StaffGroupRoleResponse>> Handle(CreateStaffGroupRoleCommand request, CancellationToken cancellationToken)
        {
            /** Make sure StaffId exist and role is Staff **/
            var user = await _userManager.FindByIdAsync(request.StaffId);

            if (user == null)
            {
                return new Result<StaffGroupRoleResponse>(
                    new BadRequestException(
                        new ApiError("Staff Id does not exist")
                    )
                );
            }

            var userRole = await _userManager.GetRolesAsync(user);
            if (userRole[0] != RoleName.Staff)
            {
                return new Result<StaffGroupRoleResponse>(
                    new BadRequestException(
                        new ApiError("Can't add User when role is not Staff")
                    )
                );
            }

            /** Make sure GroupId exist and status is New **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.GroupId
            );

            if (group == null)
            {
                return new Result<StaffGroupRoleResponse>(
                    new BadRequestException(
                        new ApiError("Group does not exist")
                    )
                );
            }

            if (group.Status != GroupStatusEnum.New && group.Status != GroupStatusEnum.Processing)
            {
                return new Result<StaffGroupRoleResponse>(
                    new BadRequestException(
                        new ApiError("Can't add Staff when group status is not New and Processing")
                    )
                );
            }

            /** Make sure GroupRole exist **/
            var groupRole = await _context.GroupRole.SingleOrDefaultAsync(
                gr => gr.Id == request.GroupRoleId
            );

            if (groupRole == null)
            {
                return new Result<StaffGroupRoleResponse>(
                    new BadRequestException(
                        new ApiError("Group Role does not exist")
                    )
                );
            }

            var staffGroupRole = _mapper.Map<E.StaffGroupRole>(request);

            await _context.StaffGroupRole.AddAsync(staffGroupRole);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<StaffGroupRoleResponse>(
                    _mapper.Map<StaffGroupRoleResponse>(staffGroupRole)
                );
            }

            return new Result<StaffGroupRoleResponse>(
                new BadRequestException(new ApiError("Create Staff to Group failed, please try again"))
            );
        }
    }
}