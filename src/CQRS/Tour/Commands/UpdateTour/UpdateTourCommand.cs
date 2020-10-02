using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Tour;
using src.Enums;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Tour.Commands.UpdateTour
{
    public class UpdateTourCommand : IRequest<Result<TourResponse>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public string TourCategoryId { get; set; }
        public double Price { get; set; }
        public TourStatusEnum Status { get; set; }
    }

    public class CreateTourHandler : IRequestHandler<UpdateTourCommand, Result<TourResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateTourHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourResponse>> Handle(
            UpdateTourCommand request,
            CancellationToken cancellationToken)
        {
            var tour = await _context.Tours
                .SingleOrDefaultAsync(t => t.Id == request.Id &&
                    t.IsDeleted == false);

            if (tour == null)
            {
                return new Result<TourResponse>(
                    new NotFoundException()
                );
            }

            /** If change category of tour, make sure new category is existed */
            if (request.TourCategoryId != null)
            {
                var newTourCategoryOfTour = await _context.TourCategories
                    .SingleOrDefaultAsync(tc => tc.Id == Guid.Parse(request.TourCategoryId) &&
                        tc.IsDeleted != true);

                if (newTourCategoryOfTour == null)
                {
                    return new Result<TourResponse>(
                        new BadRequestException(
                            new ApiError("Tour category is not existed")
                        )
                    );
                }
            }

            _mapper.Map<UpdateTourCommand, E.Tour>(request, tour);

            _context.Tours.Update(tour);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<TourResponse>(
                    _mapper.Map<TourResponse>(tour)
                );
            }

            return new Result<TourResponse>(
                new BadRequestException(
                    new ApiError("Update tour failed, please try again")
                )
            );
        }
    }
}