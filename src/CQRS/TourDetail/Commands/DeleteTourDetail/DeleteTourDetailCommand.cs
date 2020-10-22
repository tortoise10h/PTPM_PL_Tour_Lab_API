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

namespace src.CQRS.TourDetail.Commands.DeleteTourDetail
{
    public class DeleteTourDetailCommand : IRequest<Result<List<TourDetailResponse>>>
    {
        public int TourId { get; set; }
        public List<int> TouristAttractionIds { get; set; }
    }

    public class DeleteTourDetailHandler : IRequestHandler<DeleteTourDetailCommand, Result<List<TourDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ITourDetailService _tourDetailService;
        private readonly ITourService _tourService;
        public DeleteTourDetailHandler(DataContext context, IMapper mapper, ITourService tourService, ITourDetailService tourDetailService)
        {
            _context = context;
            _mapper = mapper;
            _tourService = tourService;
            _tourDetailService = tourDetailService;
        }
        public async Task<Result<List<TourDetailResponse>>> Handle(DeleteTourDetailCommand request, CancellationToken cancellationToken)
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

            /** Make sure all tourist attractions are existed */
            var isTouristAttractionIdsExist = await _tourDetailService
                .ValidateExistTourAttractionIds(request.TouristAttractionIds);

            if (!isTouristAttractionIdsExist)
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Some TouristAttraction does not exist, please try again")
                    )
                );
            }

            var touristAttractionIds = request.TouristAttractionIds.ToList();

            //** Query tour details to delete **/
            var rejectTourDetails = await _context.TourDetail
                .Where(
                    td => td.TourId == request.TourId &&
                    touristAttractionIds.Contains(td.TouristAttractionId))
                .ToListAsync();

            //** Query all tour details **/
            var allTourDetails = await _context.TourDetail
                .Where(td => td.TourId == request.TourId)
                .ToListAsync();

            //** Query all tour details after deleted to sort **/
            var filteredTourDetails = allTourDetails
                .Except(rejectTourDetails)
                .OrderBy(td => td.Index);

            int index = 1;
            foreach (var tourDetail in filteredTourDetails)
            {
                tourDetail.Index = index;
                index++;
            }

            _context.TourDetail.RemoveRange(rejectTourDetails);
            _context.TourDetail.UpdateRange(filteredTourDetails);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<TourDetailResponse>>(
                    _mapper.Map<List<TourDetailResponse>>(rejectTourDetails)
                );
            }

            return new Result<List<TourDetailResponse>>(
                new BadRequestException(new ApiError("Delete TouristAttraction in TourDetail failed, pleas try again"))
            );
        }
    }
}