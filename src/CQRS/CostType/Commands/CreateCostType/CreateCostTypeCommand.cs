using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.CostType;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.CostType.Commands.CreateCostType
{
    public class CreateCostTypeCommand : IRequest<Result<CostTypeResponse>>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class CreateCostTypeHandler : IRequestHandler<CreateCostTypeCommand, Result<CostTypeResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public CreateCostTypeHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<CostTypeResponse>> Handle(CreateCostTypeCommand request, CancellationToken cancellationToken)
        {
            var newCostType = new E.CostType {
                Name = request.Name
            };

            await _context.AddAsync(newCostType);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<CostTypeResponse>(
                    _mapper.Map<CostTypeResponse>(newCostType)
                );
            }

            return new Result<CostTypeResponse>(
                new BadRequestException(new ApiError("Create cost type failed, please try again"))
            );
        }
    }
}