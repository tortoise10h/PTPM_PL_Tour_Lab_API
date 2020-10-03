using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.CostType;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.CostType.Queries
{
    public class GetAllCostTypeQuery : PaginationQuery, IRequest<Result<PagedResponse<CostTypeResponse>>>
    {
        
    }

    public class GetAllCostTypeHandler : IRequestHandler<GetAllCostTypeQuery, Result<PagedResponse<CostTypeResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllCostTypeHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<CostTypeResponse>>> Handle(GetAllCostTypeQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.CostType.AsQueryable();
            queryable = queryable.Where(
                ct => ct.IsDeleted == false
            );
            var result = await _paginationHelper.Paginate<E.CostType, CostTypeResponse>(
                queryable, query
            );

            return result;
        }
    }
}