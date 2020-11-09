using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Tour;
using src.Common.Enums;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Tour.Commands.UpdateTour
{
    public class UpdateTourCommand : IRequest<Result<TourResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specification { get; set; }
        public int TourCategoryId { get; set; }
        public double Price { get; set; }
        public TourStatusEnum Status { get; set; }
    }

    public class UpdateTourHandler : IRequestHandler<UpdateTourCommand, Result<TourResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateTourHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourResponse>> Handle(UpdateTourCommand request, CancellationToken cancellationToken)
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


            /** tour.TourCategoryId != newTourCategoryId mean 
             * user want to change category of tour => check the exist of new tour category
            */
            if (tour.TourCategoryId != request.TourCategoryId)
            {
                var newTourCategory = await _context.TourCategories.SingleOrDefaultAsync(
                    tc => tc.Id == request.TourCategoryId &&
                    tc.IsDeleted == false
                );

                if (newTourCategory == null)
                {
                    return new Result<TourResponse>(
                        new BadRequestException(
                            new ApiError("Tour Category does not exist"))
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
                    new ApiError("Sửa tour thất bại, vui lòng thử lại"))
            );
        }
    }
}