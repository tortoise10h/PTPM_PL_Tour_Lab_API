using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupRole;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.GroupRole.Commands.UpdateGroupRole
{
    public class UpdateGroupRoleCommand : IRequest<Result<GroupRoleResponse>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UpdateGroupRoleHandler : IRequestHandler<UpdateGroupRoleCommand, Result<GroupRoleResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UpdateGroupRoleHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupRoleResponse>> Handle(UpdateGroupRoleCommand request, CancellationToken cancellationToken)
        {
            var groupRole = await _context.GroupRole.SingleOrDefaultAsync(
                gr => gr.Id == request.Id &&
                gr.IsDeleted == false
            );

            if (groupRole == null)
            {
                return new Result<GroupRoleResponse>(
                    new NotFoundException()
                );
            }

            _mapper.Map<UpdateGroupRoleCommand, E.GroupRole>(request, groupRole);
            _context.GroupRole.Update(groupRole);
            var updated = await _context.SaveChangesAsync();

            if (updated > 0)
            {
                return new Result<GroupRoleResponse>(
                    _mapper.Map<GroupRoleResponse>(groupRole)
                );
            }

            return new Result<GroupRoleResponse>(
                new BadRequestException(new ApiError("Update group role failed, please try again"))
            );
        }
    }
}