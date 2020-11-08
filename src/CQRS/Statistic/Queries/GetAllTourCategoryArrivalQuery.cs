using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using src.Contracts.V1.ResponseModels.Tour;
using src.Helpers;

namespace src.CQRS.Statistic.Queries
{
    public class GetAllTourCategoryArrivalQuery : IRequest<Result<List<TourCategoryStatisticResponse>>>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class GetAllTourCategoryArrivalHandler : IRequestHandler<GetAllTourCategoryArrivalQuery, Result<List<TourCategoryStatisticResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetAllTourCategoryArrivalHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<TourCategoryStatisticResponse>>> Handle(GetAllTourCategoryArrivalQuery query, CancellationToken cancellationToken)
        {
            var groups = _context.Group.AsQueryable();
            var tourCategory = await _context.TourCategories
                .Where(
                    tc => tc.IsDeleted == false
                )
                .Select(tc => new TourCategoryStatisticResponse
                {
                    Id = tc.Id,
                    Name = tc.Name,
                    TotalArrival = groups.Where(
                        g => g.Tour.TourCategoryId == tc.Id
                    )
                    .Count(
                        g => g.StartDate >= query.FromDate &&
                            g.StartDate <= query.ToDate &&
                            (g.Status == GroupStatusEnum.Processing || g.Status == GroupStatusEnum.Done)
                    )
                })
                .ToListAsync();

            return new Result<List<TourCategoryStatisticResponse>>(
                _mapper.Map<List<TourCategoryStatisticResponse>>(tourCategory)
            );
        }
    }
}