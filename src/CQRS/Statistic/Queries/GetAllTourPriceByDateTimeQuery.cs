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
    public class GetAllTourPriceByDateTimeQuery : IRequest<Result<List<TourWithPriceStatisticResponse>>>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class GetAllTourPriceByDateTimeHandler : IRequestHandler<GetAllTourPriceByDateTimeQuery, Result<List<TourWithPriceStatisticResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetAllTourPriceByDateTimeHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<TourWithPriceStatisticResponse>>> Handle(GetAllTourPriceByDateTimeQuery query, CancellationToken cancellationToken)
        {
            var groupDetails = _context.GroupDetail.AsQueryable();
            var tour = await _context.Tours
                .Where(
                   t => t.IsDeleted == false
                )
                .Include(t => t.Groups)
                .OrderBy(t => t.Id)
                .Select(t => new TourWithPriceStatisticResponse
                {
                    Id = t.Id,
                    Name = t.Name,
                    TourCategory = t.TourCategory.Name,
                    GroupCustomerList = t.Groups
                        .Where(
                            g => g.StartDate >= query.FromDate &&
                            g.StartDate <= query.ToDate &&
                            g.Status == GroupStatusEnum.Done
                        )
                        .Select(
                            g => g.GroupDetails.Count() * g.Price
                        ).ToList(),
                    GroupCostList = t.Groups
                        .Select(g =>
                             g.GroupCosts.Sum(gd => gd.Price)
                        ).ToList(),
                })
                .Select(x => new TourWithPriceStatisticResponse
                {
                    Id = x.Id,
                    Name = x.Name,
                    TourCategory = x.TourCategory,
                    TotalPrice = x.GroupCustomerList.Sum() - x.GroupCostList.Sum()
                })
                .ToListAsync();

            return new Result<List<TourWithPriceStatisticResponse>>(
                _mapper.Map<List<TourWithPriceStatisticResponse>>(tour)
            );
        }
    }
}