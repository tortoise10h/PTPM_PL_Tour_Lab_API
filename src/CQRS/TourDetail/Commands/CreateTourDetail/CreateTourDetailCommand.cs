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
        private readonly IMapper _mapper;
        private readonly ITourDetailService _tourDetailService;
        private readonly ITourService _tourService;

        public CreateTourDetailHandler(DataContext context, IMapper mapper, ITourDetailService tourDetailService, ITourService tourService)
        {
            _context = context;
            _mapper = mapper;
            _tourDetailService = tourDetailService;
            _tourService = tourService;
        }

        public async Task<Result<List<TourDetailResponse>>> Handle(CreateTourDetailCommand request, CancellationToken cancellationToken)
        {
            /** Make sure tourId is existed */
            var isTourExist = await _tourService.ValidateExistTour(request.TourId);
            if (!isTourExist)
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Tour does not exist")
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
                        new ApiError("Some Tourist Attraction does not exist, please try again")
                    )
                );
            }

            List<E.TourDetail> tourDetails = new List<E.TourDetail>();

            int index;

            var lastRecord = await _context.TourDetail
                .Where(x => x.TourId == request.TourId)
                .OrderByDescending(
                    x => x.Index
                )
                .FirstOrDefaultAsync();

            index = (lastRecord == null) ? 1 : lastRecord.Index + 1;

            foreach (var touristAttractionId in request.TouristAttractionIds)
            {
                tourDetails.Add(
                    new E.TourDetail
                    {
                        TourId = request.TourId,
                        TouristAttractionId = touristAttractionId,
                        Index = index
                    }
                );
                index++;
            }

            _context.TourDetail.AddRange(tourDetails);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<List<TourDetailResponse>>(
                    _mapper.Map<List<TourDetailResponse>>(tourDetails)
                );
            }

            return new Result<List<TourDetailResponse>>(
                new BadRequestException(new ApiError("Thêm địa điểm tour thất bại, vui lòng thử lại"))
            );
        }
    }
}