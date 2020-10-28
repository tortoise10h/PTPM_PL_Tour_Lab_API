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
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Queries
{
    public class GetStaffsOfGroup : PaginationQuery, IRequest<Result<PagedResponse<StaffGroupRoleResponse>>>
    {
        public int GroupId { get; set; }
    }

    public class GetStaffsOfGroupHandler : IRequestHandler<GetStaffsOfGroup, Result<PagedResponse<StaffGroupRoleResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;

        public GetStaffsOfGroupHandler(DataContext context, IPaginationHelpers paginationHelper, IMapper mapper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
            _mapper = mapper;
        }

        public async Task<Result<PagedResponse<StaffGroupRoleResponse>>> Handle(GetStaffsOfGroup query, CancellationToken cancellationToken)
        {
            var queryable = _context.StaffGroupRole.AsQueryable();

            queryable = queryable
                .Where(sgr => sgr.GroupId == query.GroupId)
                .Include(sgr => sgr.ApplicationUser)
                .Include(sgr => sgr.GroupRole);

            var result = await _paginationHelper.Paginate<E.StaffGroupRole, StaffGroupRoleResponse>(
                queryable, query);

            return result;
        }
    }
}