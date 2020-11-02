using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.GroupRole;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.GroupRole.Queries
{
    public class GetAllGroupRoleQuery : PaginationQuery, IRequest<Result<PagedResponse<GroupRoleResponse>>>
    {

    }

    public class GetAllGroupRoleHandler : IRequestHandler<GetAllGroupRoleQuery, Result<PagedResponse<GroupRoleResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGroupRoleHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<GroupRoleResponse>>> Handle(GetAllGroupRoleQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.GroupRole.AsQueryable();

            queryable = queryable.Where(
                gr => gr.IsDeleted == false
            );

            var result = await _paginationHelper.Paginate<E.GroupRole, GroupRoleResponse>(
                queryable, query
            );

            return result;
        }
    }
}