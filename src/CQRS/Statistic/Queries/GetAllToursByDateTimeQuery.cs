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
    public class GetAllToursByDateTimeQuery : IRequest<Result<List<TourWithGroupStatisticResponse>>>
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }

    public class GetAllToursByDateTimeHandler : IRequestHandler<GetAllToursByDateTimeQuery, Result<List<TourWithGroupStatisticResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetAllToursByDateTimeHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<TourWithGroupStatisticResponse>>> Handle(GetAllToursByDateTimeQuery query, CancellationToken cancellationToken)
        {
            var tour = await _context.Tours
                .Where(
                   t => t.IsDeleted == false
                )
                .Include(t => t.Groups)
                .OrderBy(t => t.Id)
                .Select(t => new TourWithGroupStatisticResponse
                {
                    Id = t.Id,
                    Name = t.Name,
                    TourCategory = t.TourCategory.Name,
                    TourArrival = t.Groups.Count(
                        g => g.StartDate >= query.FromDate &&
                            g.StartDate <= query.ToDate &&
                            g.Status == GroupStatusEnum.Done
                    ),
                    TourCancel = t.Groups.Count(
                    g => g.LastModifiedAt >= query.FromDate &&
                        g.LastModifiedAt <= query.ToDate &&
                        g.Status == GroupStatusEnum.Canceled
                    )
                })
                .ToListAsync();

            return new Result<List<TourWithGroupStatisticResponse>>(
                _mapper.Map<List<TourWithGroupStatisticResponse>>(tour)
            );

        }
    }
}