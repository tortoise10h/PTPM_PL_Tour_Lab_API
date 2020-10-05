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
        public Guid TourId { get; set; }
        public List<Guid> TouristAttractionIds { get; set; }
    }

    public class DeleteTourDetailHandler : IRequestHandler<DeleteTourDetailCommand, Result<List<TourDetailResponse>>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ITourDetailService _tourDetailService;
        public DeleteTourDetailHandler(DataContext context, IMapper mapper, ITourDetailService tourDetailService)
        {
            _context = context;
            _mapper = mapper;
            _tourDetailService = tourDetailService;
        }
        public async Task<Result<List<TourDetailResponse>>> Handle(DeleteTourDetailCommand request, CancellationToken cancellationToken)
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

            var touristAttractionIds = request.TouristAttractionIds.ToList();

            var tourDetails = await _context.TourDetail
                .Where(
                    td => td.TourId == request.TourId &&
                    touristAttractionIds.Contains(td.TouristAttractionId) &&
                    td.IsDeleted == false)
                .ToListAsync();

            foreach (var tourDetail in tourDetails)
            {
                tourDetail.IsDeleted = true;
            }

            _context.TourDetail.UpdateRange(tourDetails);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<List<TourDetailResponse>>(
                    _mapper.Map<List<TourDetailResponse>>(tourDetails)
                );
            }

            return new Result<List<TourDetailResponse>>(
                new BadRequestException(new ApiError("Delete tourist attraction failed, pleas try again"))
            );
        }
    }
}