using System.Collections.Generic;
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
    public class GetAllTourCategoriesQuery : PaginationQuery, IRequest<Result<PagedResponse<E.TourCategory>>>
    {

    }

    public class GetAllTourCategoriesHandler : IRequestHandler<GetAllTourCategoriesQuery, Result<PagedResponse<E.TourCategory>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetAllTourCategoriesHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<PagedResponse<E.TourCategory>>> Handle(
            GetAllTourCategoriesQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.TourCategories.AsQueryable();
            var result = await PaginationHelpers.Paginate<E.TourCategory>(queryable, query);

            return result;
        }
    }
}