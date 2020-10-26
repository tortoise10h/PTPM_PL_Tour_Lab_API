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

namespace src.CQRS.TourDetail.Commands.UpdateTourDetail
{
    public class UpdateTourDetailCommand : IRequest<Result<List<TourDetailResponse>>>
    {
        public int TourId { get; set; }
        public List<TourDetailUpdateModel> TourDetails { get; set; }
    }

    public class UpdateTourDetailHandler : IRequestHandler<UpdateTourDetailCommand, Result<List<TourDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ITourDetailService _tourDetailService;
        private readonly ITourService _tourService;
        public UpdateTourDetailHandler(DataContext context, IMapper mapper, ITourService tourService, ITourDetailService tourDetailService)
        {
            _context = context;
            _mapper = mapper;
            _tourService = tourService;
            _tourDetailService = tourDetailService;
        }

        public async Task<Result<List<TourDetailResponse>>> Handle(UpdateTourDetailCommand request, CancellationToken cancellationToken)
        {
            /** Make sure tourId exists */
            var isTourExist = await _tourService.ValidateExistTour(request.TourId);
            if (!isTourExist)
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Tour does not exist")
                    )
                );
            }

            //** Query all tourist attractions by tour id **/
            var allTouristAttractionsByTourId = await _context.TourDetail
                .Where(td => td.TourId == request.TourId)
                .ToListAsync();

            if (allTouristAttractionsByTourId.Count() != request.TourDetails.Count())
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("You must include all Tourist Attraction to update Index")
                    )
                );
            }

            var touristAttractionIds = request.TourDetails
                .Select(td => td.Id)
                .ToList();

            var updateTourDetails = await _context.TourDetail
                .Where(
                   td => td.TourId == request.TourId &&
                   touristAttractionIds.Contains(td.Id))
                .ToListAsync();

            if (updateTourDetails.Count() != touristAttractionIds.Count())
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Some Tourist Attraction does not exist in Tour, please try again")
                    )
                );
            }

            //** Check index is begin at 1 and asscending **//
            var indexs = request.TourDetails
                .OrderBy(td => td.Index)
                .Select(td => td.Index)
                .ToList();

            int x = 1;
            foreach (var index in indexs)
            {
                if (index != x)
                {
                    return new Result<List<TourDetailResponse>>(
                        new BadRequestException(new ApiError("An Index must begin at 1 and is ascending"))
                    );
                }
                x++;
            }

            foreach (var tourDetail in updateTourDetails)
            {
                var update = request.TourDetails
                    .Where(x => x.Id == tourDetail.Id)
                    .FirstOrDefault();

                tourDetail.Index = update.Index;
            }

            _context.UpdateRange(updateTourDetails);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<List<TourDetailResponse>>(
                    _mapper.Map<List<TourDetailResponse>>(updateTourDetails)
                );
            }

            return new Result<List<TourDetailResponse>>(
                new BadRequestException(new ApiError("Update Tour Detail failed, please try again"))
            );
        }
    }
}