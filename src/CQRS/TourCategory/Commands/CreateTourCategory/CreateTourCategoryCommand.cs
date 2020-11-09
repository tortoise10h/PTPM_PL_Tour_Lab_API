using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.TourCategory.Commands.CreateTourCategory
{
    public class CreateTourCategoryCommand : IRequest<Result<TourCategoryResponse>>
    {
        public string Name { get; set; }
    }


    public class CreateTourCategoryHandler : IRequestHandler<CreateTourCategoryCommand, Result<TourCategoryResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CreateTourCategoryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TourCategoryResponse>> Handle(CreateTourCategoryCommand request, CancellationToken cancellationToken)
        {
            var newTourCategory = new E.TourCategory
            {
                Name = request.Name
            };

            await _context.AddAsync(newTourCategory);
            var created = await _context.SaveChangesAsync();
            if (created > 0)
            {
                return new Result<TourCategoryResponse>(
                    _mapper.Map<TourCategoryResponse>(newTourCategory)
                );
            }

            return new Result<TourCategoryResponse>(
                new BadRequestException(new ApiError("Thêm thể loại tour thất bại, vui lòng thử lại"))
            );
        }
    }
}