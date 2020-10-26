using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using LanguageExt.Common;
using MediatR;
using Microsoft.AspNetCore.Identity;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.User;
using src.Entities;
using src.Helpers;

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
        public GetAllCustomersHandler(DataContext context, IPaginationHelpers paginationHelper, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _paginationHelper = paginationHelper;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<Result<PagedResponse<UserResponse>>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}