using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Group;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.Group.Queries
{
    public class GetGroupByIdQuery : IRequest<Result<GroupResponse>>
    {
        public int Id { get; set; }
        public GetGroupByIdQuery(int id)
        {
            this.Id = id;

        }
    }

    public class GetGroupByIdHandler : IRequestHandler<GetGroupByIdQuery, Result<GroupResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GetGroupByIdHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupResponse>> Handle(GetGroupByIdQuery request, CancellationToken cancellationToken)
        {
            var group = await _context.Group
                .Include(g => g.GroupCosts)
                    .ThenInclude(gc => gc.CostType)
                .Include(g => g.GroupDetails)
                    .ThenInclude(gd => gd.ApplicationUser)
                .SingleOrDefaultAsync(
                    g => g.Id == request.Id &&
                    g.IsDeleted == false
            );

            if (group == null)
            {
                return new Result<GroupResponse>(
                    new NotFoundException()
                );
            }

            return new Result<GroupResponse>(
                _mapper.Map<GroupResponse>(group)
            );
        }
    }
}