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

namespace src.CQRS.TourCategory.Commands.DeleteTourCategory
{
    public class DeleteTourCategoryCommand : IRequest<Result<TourCategoryResponse>>
    {
        public Guid Id { get; set; }
        public DeleteTourCategoryCommand(Guid tourCategoryId)
        {
            Id = tourCategoryId;
        }
    }

    public class DeleteTourCategoryHandler : IRequestHandler<DeleteTourCategoryCommand, Result<TourCategoryResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public DeleteTourCategoryHandler(DataContext context, IMapper mapper = null)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TourCategoryResponse>> Handle(DeleteTourCategoryCommand request, CancellationToken cancellationToken)
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

            tourCategory.IsDeleted = true;
            _context.TourCategories.Update(tourCategory);

            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<TourCategoryResponse>(
                    _mapper.Map<TourCategoryResponse>(tourCategory)
                );
            }
            return new Result<TourCategoryResponse>(
                new BadRequestException(new ApiError("Delete failed, please try again"))
            );
        }
    }
}