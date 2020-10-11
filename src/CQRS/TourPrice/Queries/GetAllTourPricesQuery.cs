using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Tour;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Helpers;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using E = src.Entities;

namespace src.CQRS.TourPrice.Queries
{
    public class GetAllTourPricesQuery : PaginationQuery, IRequest<Result<PagedResponse<TourPriceResponse>>>
    {

    }

    public class GetAllTourPricesHandler : IRequestHandler<GetAllTourPricesQuery, Result<PagedResponse<TourPriceResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;

        public GetAllTourPricesHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper = null)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<TourPriceResponse>>> Handle(GetAllTourPricesQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.TourPrice.AsQueryable();

            /** Custom get all tour business before pass to paginate method */
            queryable = queryable.Where(
                tc => tc.IsDeleted == false
            );

            var result = await _paginationHelper.Paginate<E.TourPrice, TourPriceResponse>(
                queryable, query);

            return result;
        }
    }
}
