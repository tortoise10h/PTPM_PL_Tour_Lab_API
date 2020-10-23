using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using LanguageExt.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using src.Contracts.V1.Exceptions;
using src.Contracts.V1.ResponseModels.GroupRole;
using src.Helpers;

namespace src.CQRS.GroupRole.Commands.DeleteGroupRole
{
    public class DeleteGroupRoleCommand : IRequest<Result<GroupRoleResponse>>
    {
        public int Id { get; set; }

        public DeleteGroupRoleCommand(int id)
        {
            Id = id;
        }
    }

    public class DeleteGroupRoleHandler : IRequestHandler<DeleteGroupRoleCommand, Result<GroupRoleResponse>>
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DeleteGroupRoleHandler(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<GroupRoleResponse>> Handle(DeleteGroupRoleCommand request, CancellationToken cancellationToken)
        {
            var groupRole = await _context.GroupRole.SingleOrDefaultAsync(
                gp => gp.Id == request.Id &&
                gp.IsDeleted == false
            );

            if (groupRole == null)
            {
                return new Result<GroupRoleResponse>(
                    new NotFoundException()
                );
            }

            var groupRoleInStaffGroupRole = await _context.StaffGroupRole.FirstOrDefaultAsync(
                sgr => sgr.GroupRoleId == request.Id &&
                    sgr.IsDeleted == false
            );

            if (groupRoleInStaffGroupRole != null)
            {
                return new Result<GroupRoleResponse>(
                    new BadRequestException(new ApiError("Can not delete GroupRole because some exist in StaffGroupRole"))
                );
            }

            groupRole.IsDeleted = true;
            _context.GroupRole.Update(groupRole);
            var deleted = await _context.SaveChangesAsync();

            if (deleted > 0)
            {
                return new Result<GroupRoleResponse>(
                    _mapper.Map<GroupRoleResponse>(groupRole)
                );
            }

            return new Result<GroupRoleResponse>(
                new BadRequestException(new ApiError("Delete group role failed, please try again"))
            );
        }
    }
}