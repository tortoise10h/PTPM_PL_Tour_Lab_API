using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TouristAttraction;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.TouristAttraction.Commands.CreateTouristAttraction
{
    public class CreateTouristAttractionCommand : IRequest<Result<TouristAttractionResponse>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class CreateTouristAttractionHandler : IRequestHandler<CreateTouristAttractionCommand, Result<TouristAttractionResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CreateTouristAttractionHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TouristAttractionResponse>> Handle(CreateTouristAttractionCommand request, CancellationToken cancellationToken)
        {
            var newTouristAttraction = _mapper.Map<E.TouristAttraction>(request);

            await _context.AddAsync(newTouristAttraction);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<TouristAttractionResponse>(
                    _mapper.Map<TouristAttractionResponse>(newTouristAttraction)
                );
            }

            return new Result<TouristAttractionResponse>(
                new BadRequestException(new ApiError("Thêm địa điểm thất bại, vui lòng thử lại"))
            );
        }
    }
}