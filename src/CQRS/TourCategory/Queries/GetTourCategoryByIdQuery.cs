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

namespace src.CQRS.TourCategory.Queries
{
    public class GetTourCategoryByIdQuery : IRequest<Result<TourCategoryResponse>>
    {
        public GetTourCategoryByIdQuery(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }

    public class GetTourCategoryByIdHandler : IRequestHandler<GetTourCategoryByIdQuery, Result<TourCategoryResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public GetTourCategoryByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Result<TourCategoryResponse>> Handle(GetTourCategoryByIdQuery request, CancellationToken cancellationToken)
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

            return new Result<TourCategoryResponse>(
                _mapper.Map<TourCategoryResponse>(tourCategory)
            );
        }
    }
}