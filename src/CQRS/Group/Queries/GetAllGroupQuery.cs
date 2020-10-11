using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Group;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Queries
{
    public class GetAllGroupQuery : PaginationQuery, IRequest<Result<PagedResponse<GroupResponse>>>
    {

    }

    public class GetAllGroupHandler : IRequestHandler<GetAllGroupQuery, Result<PagedResponse<GroupResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGroupHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<GroupResponse>>> Handle(GetAllGroupQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.Group.AsQueryable();
            queryable = queryable.Where(
                g => g.IsDeleted == false
            );
            var result = await _paginationHelper.Paginate<E.Group, GroupResponse>(
                queryable, query
            );

            return result;
        }
    }
}