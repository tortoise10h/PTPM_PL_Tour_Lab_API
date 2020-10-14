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
using E = src.Entities;

namespace src.CQRS.Tour.Commands.CreateTour
{
    public class CreateTourCommand : IRequest<Result<TourResponse>>
    {
        public string Name { get; set; }
        public string Specification { get; set; }
        public int TourCategoryId { get; set; }
        public double Price { get; set; }
    }

    public class CreateTourHandler : IRequestHandler<CreateTourCommand, Result<TourResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateTourHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourResponse>> Handle(
            CreateTourCommand request,
            CancellationToken cancellationToken)
        {
            var tourEntity = _mapper.Map<E.Tour>(request);

            /** Make sure tour category of tour is existed */
            var tourCategory = await _context.TourCategories
                .SingleOrDefaultAsync(
                    tc => tc.Id == tourEntity.TourCategoryId &&
                    tc.IsDeleted != true);
            if (tourCategory == null)
            {
                return new Result<TourResponse>(
                    new BadRequestException(
                        new ApiError("tour category is not existed (tourCategoryId)"))
                );
            }

            await _context.Tours.AddAsync(tourEntity);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<TourResponse>(
                    _mapper.Map<TourResponse>(tourEntity)
                );
            }

            return new Result<TourResponse>(
                new BadRequestException(new ApiError("Create tour failed, please try again"))
            );
        }
    }
}