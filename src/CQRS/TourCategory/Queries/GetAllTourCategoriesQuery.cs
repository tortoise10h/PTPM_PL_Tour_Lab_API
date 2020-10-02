using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.TourCategory.Queries
{
    public class GetAllTourCategoriesQuery : PaginationQuery, IRequest<Result<PagedResponse<TourCategoryResponse>>>
    {

    }

    public class GetAllTourCategoriesHandler : IRequestHandler<GetAllTourCategoriesQuery, Result<PagedResponse<TourCategoryResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;
        public GetAllTourCategoriesHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<TourCategoryResponse>>> Handle(
            GetAllTourCategoriesQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.TourCategories.AsQueryable();
            queryable = queryable.Where(
                tc => tc.IsDeleted == false
            );
            var result = await _paginationHelper.Paginate<E.TourCategory, TourCategoryResponse>(
                queryable, query);

            return result;
        }
    }
}