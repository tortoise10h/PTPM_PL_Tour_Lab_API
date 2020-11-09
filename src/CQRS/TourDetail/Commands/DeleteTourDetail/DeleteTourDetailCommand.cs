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
        public List<int> Ids { get; set; }
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

            var touristAttractionIds = request.Ids.ToList();

            //** Query tourist attractions by tour id to delete **/
            var rejectTourDetails = await _context.TourDetail
                .Where(
                    td => td.TourId == request.TourId &&
                    touristAttractionIds.Contains(td.Id))
                .ToListAsync();

            if (rejectTourDetails.Count() != touristAttractionIds.Count())
            {
                return new Result<List<TourDetailResponse>>(
                    new BadRequestException(
                        new ApiError("Some Tourist Attraction does not exist in Tour, please try again")
                    )
                );
            }

            //** Query all tourist attractions by tour id **/
            var allTourDetails = await _context.TourDetail
                .Where(td => td.TourId == request.TourId)
                .ToListAsync();

            //** Query all tourist attractions after deleted to sort **/
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
                new BadRequestException(new ApiError("Xoá địa điểm tour thất bại, vui lòng thử lại"))
            );
        }
    }
}