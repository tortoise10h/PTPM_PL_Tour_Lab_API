using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;

namespace src.Helpers
{
    public class PaginationHelpers
    {
        public static PagedResponse<T> CreatePaginatedResponse<T>(
            PaginationQuery query,
            List<T> response,
            int total)
        {
            int totalPage = (int)Math.Ceiling((double)total / query.Limit);

            return new PagedResponse<T>
            {
                Data = response,
                CurrentPage = query.Page,
                PageSize = query.Limit,
                TotalPages = totalPage == 0 ? 1 : totalPage,
                TotalItems = total
            };
        }
        public static async Task<PagedResponse<T>> Paginate<T>(
            IQueryable<T> queryable,
            PaginationQuery query)
        {
            int skip = (query.Page - 1) * query.Limit;

            var entities = await queryable
                .Skip(skip)
                .Take(query.Limit)
                .ToListAsync();
            var totalEntities = await queryable.CountAsync();
            return CreatePaginatedResponse(query, entities, totalEntities);
        }
    }
}