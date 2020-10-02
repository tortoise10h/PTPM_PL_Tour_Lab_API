using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TouristAttraction;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.TouristAttraction.Queries
{
    public class GetAllTouristAttractionQuery : PaginationQuery, IRequest<Result<PagedResponse<TouristAttractionResponse>>>
    {
        
    }

    public class GetAllTouristAttractionHandler : IRequestHandler<GetAllTouristAttractionQuery, Result<PagedResponse<TouristAttractionResponse>>>
    {   
        private readonly DataContext _context;
        private readonly IMapper _mapper;
         private readonly IPaginationHelpers _paginationHelper;
        public GetAllTouristAttractionHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<TouristAttractionResponse>>> Handle(GetAllTouristAttractionQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.TouristAttraction.AsQueryable();
            queryable = queryable.Where(
                ta => ta.IsDeleted == false
            );
            var result = await _paginationHelper.Paginate<E.TouristAttraction, TouristAttractionResponse>(
                queryable, query
            );

            return result;
        }
    }
}