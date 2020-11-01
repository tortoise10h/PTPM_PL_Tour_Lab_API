using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.StaffGroupRole;
using src.Contracts.V1.ResponseModels.User;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Queries
{
    public class GetStaffsWithoutRoleOfGroup : PaginationQuery, IRequest<Result<PagedResponse<UserResponse>>>
    {
        public int GroupId { get; set; }
    }

    public class GetStaffsWithoutRoleOfGroupHandler : IRequestHandler<GetStaffsWithoutRoleOfGroup, Result<PagedResponse<UserResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;

        public GetStaffsWithoutRoleOfGroupHandler(DataContext context, IPaginationHelpers paginationHelper, IMapper mapper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
            _mapper = mapper;
        }

        public async Task<Result<PagedResponse<UserResponse>>> Handle(GetStaffsWithoutRoleOfGroup query, CancellationToken cancellationToken)
        {
            var queryable = _context.Users.AsQueryable();

            var usersInGroup = await _context.StaffGroupRole
                .Where(sgr => sgr.GroupId == query.GroupId)
                .Select(sgr => sgr.StaffId)
                .Distinct()
                .ToListAsync();

            queryable = queryable
                .Where(
                    u => usersInGroup.Contains(u.Id)
                );

            var result = await _paginationHelper.Paginate<E.ApplicationUser, UserResponse>(
                queryable, query);

            return result;
        }
    }
}