using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.GroupCost;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Queries
{
    public class GetGroupCostsOfGroup : PaginationQuery, IRequest<Result<PagedResponse<GroupCostResponse>>>
    {
        public int GroupId { get; set; }
    }

    public class GetGroupCostsOfGroupHandler : IRequestHandler<GetGroupCostsOfGroup, Result<PagedResponse<GroupCostResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;

        public GetGroupCostsOfGroupHandler(DataContext context, IPaginationHelpers paginationHelper, IMapper mapper)
        {
            _context = context;
            _paginationHelper = paginationHelper;
            _mapper = mapper;
        }

        public async Task<Result<PagedResponse<GroupCostResponse>>> Handle(GetGroupCostsOfGroup query, CancellationToken cancellationToken)
        {
            var queryable = _context.GroupCost.AsQueryable();

            queryable = queryable
                .Where(gc => gc.GroupId == query.GroupId)
                .Include(gc => gc.CostType);

            var result = await _paginationHelper.Paginate<E.GroupCost, GroupCostResponse>(
                queryable, query);

            return result;
        }
    }
}