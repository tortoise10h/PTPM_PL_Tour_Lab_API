using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Tour.Queries
{
    public class GetTourPricesOfTourQuery : PaginationQuery, IRequest<Result<PagedResponse<TourPriceResponse>>>
    {
        public int TourId { get; set; }
    }

    public class GetTourPricesOfTourHandler : IRequestHandler<GetTourPricesOfTourQuery, Result<PagedResponse<TourPriceResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;

        public GetTourPricesOfTourHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper = null)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<TourPriceResponse>>> Handle(GetTourPricesOfTourQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.TourPrice.AsQueryable();

            /** Custom get all tour business before pass to paginate method */
            queryable = queryable.Where(
                tp => tp.IsDeleted == false &&
                tp.TourId == query.TourId
            );

            var result = await _paginationHelper.Paginate<E.TourPrice, TourPriceResponse>(
                queryable, query);

            return result;
        }
    }
}