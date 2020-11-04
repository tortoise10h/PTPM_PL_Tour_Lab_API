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
        public DeleteTourCommand(int id)
        {
            this.Id = id;

        }

        public int Id { get; set; }
    }

    public class DeleteTourCommandHandler : IRequestHandler<DeleteTourCommand, Result<TourResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteTourCommandHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourResponse>> Handle(DeleteTourCommand request, CancellationToken cancellationToken)
        {
            var tour = await _context.Tours.SingleOrDefaultAsync(
                ct => ct.Id == request.Id &&
                ct.IsDeleted == false
            );

            if (tour == null)
            {
                return new Result<TourResponse>(
                    new NotFoundException()
                );
            }

            var tourDetail = await _context.TourDetail.FirstOrDefaultAsync(
                td => td.TourId == request.Id &&
                td.IsDeleted == false
            );

            var tourPrice = await _context.TourPrice.FirstOrDefaultAsync(
                tp => tp.TourId == request.Id &&
                tp.IsDeleted == false
            );

            var groupInTour = await _context.Group.FirstOrDefaultAsync(
                g => g.TourId == request.Id &&
                g.IsDeleted == false
            );

            if (tourDetail != null)
            {
                return new Result<TourResponse>(
                    new BadRequestException(new ApiError("Can't delete this Tour because it is already in use in Tour Detail"))
                );
            }


            if (tourPrice != null)
            {
                return new Result<TourResponse>(
                    new BadRequestException(new ApiError("Can't delete this Tour because it is already in use in Tour Price"))
                );
            }


            if (groupInTour != null)
            {
                return new Result<TourResponse>(
                    new BadRequestException(new ApiError("Can't delete this Tour because it is already in use in Group"))
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
                new BadRequestException(new ApiError("Delete Group failed, please try again"))
            );
        }
    }
}