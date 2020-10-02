using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Tour;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Tour.Queries
{
    public class GetAllToursQuery : PaginationQuery, IRequest<Result<PagedResponse<TourResponse>>>
    {

    }

    public class GetAllToursHandler : IRequestHandler<GetAllToursQuery, Result<PagedResponse<TourResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;
        private readonly IMapper _mapper;

        public GetAllToursHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper = null)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<TourResponse>>> Handle(GetAllToursQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.Tours.AsQueryable();

            /** Custom get all tour business before pass to paginate method */
            queryable = queryable.Where(
                tc => tc.IsDeleted == false
            );

            var result = await _paginationHelper.Paginate<E.Tour, TourResponse>(
                queryable, query);

            return result;
        }
    }
}