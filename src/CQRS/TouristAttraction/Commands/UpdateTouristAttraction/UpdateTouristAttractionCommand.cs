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

namespace src.CQRS.TouristAttraction.Commands.UpdateTouristAttraction
{
    public class UpdateTouristAttractionCommand : IRequest<Result<TouristAttractionResponse>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class UpdateTouristAttractionHandler : IRequestHandler<UpdateTouristAttractionCommand, Result<TouristAttractionResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateTouristAttractionHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TouristAttractionResponse>> Handle(UpdateTouristAttractionCommand request, CancellationToken cancellationToken)
        {
            var touristAttraction = await _context.TouristAttraction.SingleOrDefaultAsync(
                ta => ta.Id == request.Id &&
                ta.IsDeleted != true
            );

            if (touristAttraction == null)
            {
                return new Result<TouristAttractionResponse>(
                    new NotFoundException()
                );
            }

            touristAttraction.Name = request.Name;
            touristAttraction.Description = request.Description;

            _context.TouristAttraction.Update(touristAttraction);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<TouristAttractionResponse>(
                    _mapper.Map<TouristAttractionResponse>(touristAttraction)
                );
            }

            return new Result<TouristAttractionResponse>(
                new BadRequestException(new ApiError("Update tourist attraction failed, please try again"))  
            );
        }
    }
}