using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Tour;
using src.Helpers;

namespace src.CQRS.Tour.Queries
{
    public class GetTourByIdQuery : IRequest<Result<TourResponse>>
    {
        public GetTourByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }

    public class GetTourByIdHandler : IRequestHandler<GetTourByIdQuery, Result<TourResponse>>
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public GetTourByIdHandler(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Result<TourResponse>> Handle(
            GetTourByIdQuery request,
            CancellationToken cancellationToken)
        {
            var tour = await _context.Tours
                .Include(t => t.TourCategory)
                .Include(t => t.TourDetails)
                    .ThenInclude(td => td.TouristAttraction)
                .SingleOrDefaultAsync(
                    t => t.Id == request.Id &&
                    t.IsDeleted != true);

            tour.TourDetails = tour.TourDetails.OrderBy(td => td.Index).ToList();

            if (tour == null)
            {
                return new Result<TourResponse>(
                    new NotFoundException()
                );
            }

            return new Result<TourResponse>(
                _mapper.Map<TourResponse>(tour)
            );
        }
    }
}