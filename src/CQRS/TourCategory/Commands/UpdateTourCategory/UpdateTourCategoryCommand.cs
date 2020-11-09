using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.Helpers;

namespace src.CQRS.TourCategory.Commands.UpdateTourCategory
{
    public class UpdateTourCategoryCommand : IRequest<Result<TourCategoryResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateTourCategoryHandler : IRequestHandler<UpdateTourCategoryCommand, Result<TourCategoryResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public UpdateTourCategoryHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<TourCategoryResponse>> Handle(
            UpdateTourCategoryCommand request,
            CancellationToken cancellationToken)
        {
            var tourCategory = await _context.TourCategories.SingleOrDefaultAsync(
                tc => tc.Id == request.Id &&
                tc.IsDeleted != true
            );

            if (tourCategory == null)
            {
                return new Result<TourCategoryResponse>(
                    new NotFoundException()
                );
            }

            tourCategory.Name = request.Name;
            _context.TourCategories.Update(tourCategory);

            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<TourCategoryResponse>(
                    _mapper.Map<TourCategoryResponse>(tourCategory)
                );
            }

            return new Result<TourCategoryResponse>(
                new BadRequestException(new ApiError("Sửa thể loại tour thất bại, vui lòng thử lại"))
            );
        }
    }
}