using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.Group;
using src.Helpers;

namespace src.CQRS.Group.Commands.DeleteGroup
{
    public class DeleteGroupCommand : IRequest<Result<GroupResponse>>
    {
        public DeleteGroupCommand(int id)
        {
            this.Id = id;

        }
        public int Id { get; set; }
    }

    public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, Result<GroupResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteGroupHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupResponse>> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
        {
            var group = await _context.Group.SingleOrDefaultAsync(
                g => g.Id == request.Id &&
                g.IsDeleted == false
            );

            if (group == null)
            {
                return new Result<GroupResponse>(
                    new NotFoundException()
                );
            }

            group.IsDeleted = true;
            _context.Group.Update(group);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<GroupResponse>(
                    _mapper.Map<GroupResponse>(group)
                );
            }

            return new Result<GroupResponse>(
                new BadRequestException(new ApiError("Delete group failed, please try again"))
            );
        }
    }
}