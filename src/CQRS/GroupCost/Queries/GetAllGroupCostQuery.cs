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

namespace src.CQRS.GroupCost.Queries
{
    public class GetAllGroupCostQuery : PaginationQuery, IRequest<Result<PagedResponse<GroupCostResponse>>>
    {

    }

    public class GetAllGroupCostHandler : IRequestHandler<GetAllGroupCostQuery, Result<PagedResponse<GroupCostResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGroupCostHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }
        public async Task<Result<PagedResponse<GroupCostResponse>>> Handle(GetAllGroupCostQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.GroupCost.AsQueryable();

            var result = await _paginationHelper.Paginate<E.GroupCost, GroupCostResponse>(
                queryable, query
            );

            return result;
        }
    }
}