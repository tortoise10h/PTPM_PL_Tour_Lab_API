using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.RequestModels;
using src.Contracts.V1.ResponseModels;

namespace src.Helpers
{
    public interface IPaginationHelpers
    {
        Task<PagedResponse<TResponse>> Paginate<TEntity, TResponse>(
            IQueryable<TEntity> queryable,
            PaginationQuery query);
    }

    public class PaginationHelpers : IPaginationHelpers
    {
        private readonly IMapper _mapper;

        public PaginationHelpers(IMapper mapper)
        {
            _mapper = mapper;
        }

        private PagedResponse<TResponse> CreatePaginatedResponse<TEntity, TResponse>(
            PaginationQuery query,
            List<TEntity> entities,
            int total)
        {
            int totalPage = (int)Math.Ceiling((double)total / query.Limit);

            return new PagedResponse<TResponse>
            {
                Data = _mapper.Map<IEnumerable<TResponse>>(entities),
                CurrentPage = query.Page,
                PageSize = query.Limit,
                TotalPages = totalPage == 0 ? 1 : totalPage,
                TotalItems = total
            };
        }
        public async Task<PagedResponse<TResponse>> Paginate<TEntity, TResponse>(
            IQueryable<TEntity> queryable,
            PaginationQuery query)
        {
            int skip = (query.Page - 1) * query.Limit;

            queryable = CustomSortQuery<TEntity>(queryable, query.SortName, query.IsAscending);
            var entities = await queryable
                .Skip(skip)
                .Take(query.Limit)
                .ToListAsync();
            var totalEntities = await queryable.CountAsync();
            return CreatePaginatedResponse<TEntity, TResponse>(
                query, entities, totalEntities);
        }

        public IQueryable<TEntity> CustomSortQuery<TEntity>(
            IQueryable<TEntity> queryable,
            string sortName,
            bool isAscending
        )
        {
            var type = typeof(TEntity);
            var field = type.GetField(sortName);
            var parameter = Expression.Parameter(type, "p");
            PropertyInfo property = typeof(TEntity).GetProperty(sortName);
            if (property == null)
            {
                /** If field name is provided by client is not exist 
                 * then take the default field
                 */
                property = typeof(TEntity).GetProperty(PaginationDefault.SortName);
            }

            Expression propertyAccess = Expression.MakeMemberAccess(parameter, property);

            var orderByExp = Expression.Lambda(propertyAccess, parameter);
            MethodCallExpression resultExp = Expression.Call(
                typeof(Queryable),
                isAscending ? "OrderBy" : "OrderByDescending",
                new[] { type, property.PropertyType },
                queryable.Expression,
                Expression.Quote(orderByExp)
            );

            return queryable.Provider.CreateQuery<TEntity>(resultExp);
        }
    }
}