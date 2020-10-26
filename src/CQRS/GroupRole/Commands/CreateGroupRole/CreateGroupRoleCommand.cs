using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupRole;
using src.Helpers;
using E = src.Entities;

namespace src.CQRS.GroupRole.Commands.CreateGroupRole
{
    public class CreateGroupRoleCommand : IRequest<Result<GroupRoleResponse>>
    {
        public string Name { get; set; }
    }

    public class CreateGroupRoleHandler : IRequestHandler<CreateGroupRoleCommand, Result<GroupRoleResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CreateGroupRoleHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupRoleResponse>> Handle(CreateGroupRoleCommand request, CancellationToken cancellationToken)
        {
            var newGroupRole = _mapper.Map<E.GroupRole>(request);

            await _context.AddAsync(newGroupRole);
            var created = await _context.SaveChangesAsync();

            if (created > 0)
            {
                return new Result<GroupRoleResponse>(
                    _mapper.Map<GroupRoleResponse>(newGroupRole)
                );
            }

            return new Result<GroupRoleResponse>(
                new BadRequestException(new ApiError("Create Group Role failed, please try again"))
            );
        }
    }
}