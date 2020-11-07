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
using System.Collections.Generic;
using System.Linq;

namespace src.CQRS.StaffGroupRole.Commands.CreateStaffGroupRole
{
    public class CreateStaffGroupRoleCommand : IRequest<Result<List<StaffGroupRoleResponse>>>
    {
        public int GroupId { get; set; }
        public string StaffId { get; set; }
        public List<int> GroupRoles { get; set; }
    }

    public class CreateStaffGroupRoleHandler : IRequestHandler<CreateStaffGroupRoleCommand, Result<List<StaffGroupRoleResponse>>>
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

        public async Task<Result<List<StaffGroupRoleResponse>>> Handle(CreateStaffGroupRoleCommand request, CancellationToken cancellationToken)
        {
            /** Make sure GroupId exist and status is New **/
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.GroupId
            );

            if (group == null)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Group does not exist")
                    )
                );
            }

            if (group.Status != GroupStatusEnum.New && group.Status != GroupStatusEnum.Processing)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Can't add Staff when group status is not New and Processing")
                    )
                );
            }

            /** Make sure StaffId exist and role is Staff **/
            var user = await _userManager.FindByIdAsync(request.StaffId);

            if (user == null)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Staff Id does not exist")
                    )
                );
            }

            var userRole = await _userManager.GetRolesAsync(user);
            if (userRole[0] != RoleName.Staff)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Can't add User when role is not Staff")
                    )
                );
            }

            /** Make sure GroupRole exist **/
            var roles = request.GroupRoles
                .ToList();

            var groupRoles = await _context.GroupRole
                .Where(
                    gr => gr.IsDeleted == false &&
                    roles.Contains(gr.Id)
                )
                .ToListAsync();

            if (roles.Count() != groupRoles.Count())
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Some Group Role does not exist")
                    )
                );
            }

            //** Make sure Staff must have each role 1 time **/
            var existStaffGroupRoles = await _context.StaffGroupRole
                .Where(
                    sgr => sgr.StaffId == request.StaffId &&
                    sgr.GroupId == request.GroupId &&
                    roles.Contains(sgr.GroupRoleId)
                )
                .ToListAsync();

            if (existStaffGroupRoles.Count() > 0)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    new BadRequestException(
                        new ApiError("Staff must have each role once time")
                    )
                );
            }

            List<E.StaffGroupRole> staffGroupRoles = new List<E.StaffGroupRole>();

            foreach (var role in roles)
            {
                staffGroupRoles.Add(
                    new E.StaffGroupRole
                    {
                        GroupId = request.GroupId,
                        StaffId = request.StaffId,
                        GroupRoleId = role
                    }
                );
            }

            _context.StaffGroupRole.AddRange(staffGroupRoles);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<List<StaffGroupRoleResponse>>(
                    _mapper.Map<List<StaffGroupRoleResponse>>(staffGroupRoles)
                );
            }

            return new Result<List<StaffGroupRoleResponse>>(
                new BadRequestException(new ApiError("Create Staff to Group failed, please try again"))
            );
        }
    }
}