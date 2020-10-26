using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Tour;
using src.Contracts.V1.ResponseModels.User;
using src.Entities;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.User.Queries
{
    public class GetAllCustomersQuery : PaginationQuery, IRequest<Result<PagedResponse<UserResponse>>>
    {

    }

    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomersQuery, Result<PagedResponse<UserResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public GetAllCustomersHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper = null, UserManager<ApplicationUser> userManager = null, RoleManager<IdentityRole> roleManager = null)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<Result<PagedResponse<UserResponse>>> Handle(GetAllCustomersQuery query, CancellationToken cancellationToken)
        {
            var role = await _roleManager.FindByNameAsync(RoleName.Customer);
            var queryable = _userManager.Users.AsQueryable();

            queryable = queryable
                .Join(_context.UserRoles,
                    u => u.Id,
                    ur => ur.UserId,
                    (u, ur) =>
                    new
                    {
                        User = new E.ApplicationUser
                        {
                            Id = u.Id,
                            Email = u.Email,
                            PhoneNumber = u.PhoneNumber,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            IdentityUserRoles = new List<IdentityUserRole<string>>() { ur },
                        },
                        UserRole = ur
                    }
                )
                .Where(temp => temp.UserRole.RoleId == role.Id)
                .Select(u => new E.ApplicationUser
                {
                    Id = u.User.Id,
                    Email = u.User.Email,
                    PhoneNumber = u.User.PhoneNumber,
                    FirstName = u.User.FirstName,
                    LastName = u.User.LastName
                });

            /** Because some stupid bug that I still can't fix, this is a best way now */
            query.SortName = query.SortName == "CreatedAt" ? query.SortName = "Email" : query.SortName;
            var result = await _paginationHelper.Paginate<E.ApplicationUser, UserResponse>(
                queryable, query);

            return result;
        }
    }
}