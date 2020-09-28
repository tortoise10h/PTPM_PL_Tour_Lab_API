using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.TourCategory.Commands.CreateTourCategory
{
    public class CreateTourCategoryCommand : IRequest<CreateResult<TourCategoryResponse>>
    {
        public string Name { get; set; }
    }

    public class CreateTourCategoryHandler : IRequestHandler<CreateTourCategoryCommand, CreateResult<TourCategoryResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CreateTourCategoryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<CreateResult<TourCategoryResponse>> Handle(CreateTourCategoryCommand request, CancellationToken cancellationToken)
        {
            var newTourCategory = new E.TourCategory
            {
                Name = request.Name
            };

            await _context.AddAsync(newTourCategory);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new CreateResult<TourCategoryResponse>
                {
                    IsSuccess = true,
                    EntityReturn = _mapper.Map<TourCategoryResponse>(newTourCategory)
                };
            }

            return new CreateResult<TourCategoryResponse>
            {
                IsSuccess = false,
                Errors = new List<string>() {
                    "Create tour category failed"
                }
            };

        }
    }

}