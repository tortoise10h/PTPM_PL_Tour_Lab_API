using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TouristAttraction;
using src.Helpers;

namespace src.CQRS.TouristAttraction.Commands.DeleteTouristAttraction
{
    public class DeleteTouristAttractionCommand : IRequest<Result<TouristAttractionResponse>>
    {
        public DeleteTouristAttractionCommand(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
    }

    public class DeleteTouristAttractionHandler : IRequestHandler<DeleteTouristAttractionCommand, Result<TouristAttractionResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public DeleteTouristAttractionHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TouristAttractionResponse>> Handle(DeleteTouristAttractionCommand request, CancellationToken cancellationToken)
        {
            var touristAttraction = await _context.TouristAttraction.SingleOrDefaultAsync(
                ta => ta.Id == request.Id &&
                ta.IsDeleted == false
            );

            if (touristAttraction == null)
            {
                return new Result<TouristAttractionResponse>(
                    new NotFoundException()
                );
            }

            var touristAttractionInTourDetail = await _context.TourDetail.FirstOrDefaultAsync(
                td => td.TouristAttractionId == request.Id
            );

            if (touristAttractionInTourDetail != null)
            {
                return new Result<TouristAttractionResponse>(
                    new BadRequestException(new ApiError("Can't delete Tourist Attraction because it is already in use in Tour Detail"))
                );
            }

            touristAttraction.IsDeleted = true;
            _context.TouristAttraction.Update(touristAttraction);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<TouristAttractionResponse>(
                    _mapper.Map<TouristAttractionResponse>(touristAttraction)
                );
            }

            return new Result<TouristAttractionResponse>(
                new BadRequestException(new ApiError("Delete Tourist Attraction failed, please try again"))
            );
        }
    }
}