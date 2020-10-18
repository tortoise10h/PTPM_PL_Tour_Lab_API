using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.GroupDetail;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.GroupDetail.Queries
{
    public class GetAllGroupDetailQuery : PaginationQuery, IRequest<Result<PagedResponse<GroupDetailResponse>>>
    {

    }

    public class GetAllGroupDetailHandler : IRequestHandler<GetAllGroupDetailQuery, Result<PagedResponse<GroupDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IPaginationHelpers _paginationHelper;

        public GetAllGroupDetailHandler(DataContext context, IMapper mapper, IPaginationHelpers paginationHelper)
        {
            _context = context;
            _mapper = mapper;
            _paginationHelper = paginationHelper;
        }
        public async Task<Result<PagedResponse<GroupDetailResponse>>> Handle(GetAllGroupDetailQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.GroupDetail.AsQueryable();

            queryable = queryable
                .Include(gd => gd.ApplicationUser);

            var result = await _paginationHelper.Paginate<E.GroupDetail, GroupDetailResponse>(
                queryable, query
            );

            return result;
        }
    }
}