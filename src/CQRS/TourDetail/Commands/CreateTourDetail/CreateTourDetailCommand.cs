using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TourDetail;
using src.Helpers;
using src.Services;
using E = src.Entities;

namespace src.CQRS.TourDetail.Commands.CreateTourDetail
{
    public class CreateTourDetailCommand : IRequest<Result<List<TourDetailResponse>>>
    {
        public int TourId { get; set; }
        public List<int> TouristAttractionIds { get; set; }
    }

    public class CreateTourDetailHandler : IRequestHandler<CreateTourDetailCommand, Result<List<TourDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mappper;
        private readonly ITourDetailService _tourDetailService;

        public CreateTourDetailHandler(DataContext context, IMapper mappper, ITourDetailService tourDetailService)
        {
            _context = context;
            _mappper = mappper;
            _tourDetailService = tourDetailService;
        }

        public async Task<Result<List<TourDetailResponse>>> Handle(CreateTourDetailCommand request, CancellationToken cancellationToken)
        {
            /** Make sure tourId is existed */
            var tour = await _context.Tours
                .SingleOrDefaultAsync(
                    t => t.Id == request.TourId &&
                    t.IsDeleted == false
                );
            if (tour == null)
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Tour is not existed (tourId)")
                    )
                );
            }

            /** Make sure all tourist attractions are existed */
            var isTouristAttractionIdsExist = await _tourDetailService
                .ValidateExistTourAttractionIds(request.TouristAttractionIds);

            if (!isTouristAttractionIdsExist)
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Some tourist attractions are not existed, please try again")
                    )
                );
            }

            List<E.TourDetail> tourDetails = new List<E.TourDetail>();

            foreach (var touristAttractionId in request.TouristAttractionIds)
            {
                tourDetails.Add(
                    new E.TourDetail
                    {
                        TourId = request.TourId,
                        TouristAttractionId = touristAttractionId
                    }
                );
            }

            _context.TourDetail.AddRange(tourDetails);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<TourDetailResponse>>(
                    _mappper.Map<List<TourDetailResponse>>(tourDetails)
                );
            }

            return new Result<List<TourDetailResponse>>(
                new BadRequestException(new ApiError("Create tour detail failed, please try again"))
            );
        }
    }
}