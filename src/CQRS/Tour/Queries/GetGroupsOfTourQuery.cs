using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Group;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Tour.Queries
{
    public class GetGroupsOfTourQuery : PaginationQuery, IRequest<Result<PagedResponse<GroupResponse>>>
    {
        public int TourId { get; set; }
    }

    public class GetGroupsOfTourHandler : IRequestHandler<GetGroupsOfTourQuery, Result<PagedResponse<GroupResponse>>>
    {
        private readonly DataContext _context;
        private readonly IPaginationHelpers _paginationHelper;

        public GetGroupsOfTourHandler(DataContext context, IPaginationHelpers paginationHelper = null)
        {
            _context = context;
            _paginationHelper = paginationHelper;
        }

        public async Task<Result<PagedResponse<GroupResponse>>> Handle(GetGroupsOfTourQuery query, CancellationToken cancellationToken)
        {
            var queryable = _context.Group.AsQueryable();

            /** Custom get all tour business before pass to paginate method */
            queryable = queryable.Where(
                tp => tp.IsDeleted == false &&
                tp.TourId == query.TourId
            );

            var result = await _paginationHelper.Paginate<E.Group, GroupResponse>(
                queryable, query);

            return result;
        }
    }
}
