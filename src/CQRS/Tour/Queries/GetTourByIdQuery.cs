using System;
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
        public GetTourByIdQuery(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
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