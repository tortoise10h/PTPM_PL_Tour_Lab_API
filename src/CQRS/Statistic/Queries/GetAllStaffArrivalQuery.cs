using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.ResponseModels.Tour;
using src.Entities;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Statistic.Queries
{
    public class GetAllStaffArrivalQuery : IRequest<Result<List<TourWithStaffStatisticResponse>>>
    {

    }

    public class GetAllStaffArrivalHandler : IRequestHandler<GetAllStaffArrivalQuery, Result<List<TourWithStaffStatisticResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public GetAllStaffArrivalHandler(DataContext context, IMapper mapper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Result<List<TourWithStaffStatisticResponse>>> Handle(GetAllStaffArrivalQuery request, CancellationToken cancellationToken)
        {
            IList<ApplicationUser> users = await _userManager.GetUsersInRoleAsync(RoleName.Staff);

            var userIds = users.Select(u => u.Id).ToList();

            var staffs = await _context.Users
                .Where(u => userIds.Contains(u.Id))
                .Include(u => u.StaffGroupRoles)
                .Select(u => new TourWithStaffStatisticResponse
                {
                    Id = u.Id,
                    Email = u.Email,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    PhoneNumber = u.PhoneNumber,
                    TotalArrival = u.StaffGroupRoles.Select(
                        sgr =>
                        new
                        {
                            sgr.StaffId,
                            sgr.GroupId
                        }
                    ).Distinct().Count()
                })
                .ToListAsync();

            return new Result<List<TourWithStaffStatisticResponse>>(
                _mapper.Map<List<TourWithStaffStatisticResponse>>(staffs)
            );
        }
    }
}