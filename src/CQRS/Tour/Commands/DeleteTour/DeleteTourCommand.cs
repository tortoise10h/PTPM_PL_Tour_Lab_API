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

namespace src.CQRS.Tour.Commands.DeleteTour
{
    public class DeleteTourCommand : IRequest<Result<TourResponse>>
    {
        public DeleteTourCommand(Guid id)
        {
            this.Id = id;

        }
        public Guid Id { get; set; }
    }

    public class DeleteTourHandler : IRequestHandler<DeleteTourCommand, Result<TourResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public DeleteTourHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TourResponse>> Handle(DeleteTourCommand request, CancellationToken cancellationToken)
        {
            var tour = await _context.Tours.SingleOrDefaultAsync(
                ta => ta.Id == request.Id &&
                ta.IsDeleted == false
            );

            if (tour == null)
            {
                return new Result<TourResponse>(
                    new NotFoundException()
                );
            }

            tour.IsDeleted = true;
            _context.Tours.Update(tour);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<TourResponse>(
                    _mapper.Map<TourResponse>(tour)
                );
            }

            return new Result<TourResponse>(
                new BadRequestException(
                    new ApiError("Delete tourist attraction failed, pleas try again"))
            );
        }
    }
}