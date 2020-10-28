using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.GroupRole;
using src.CQRS.GroupRole.Commands.CreateGroupRole;
using src.CQRS.GroupRole.Commands.DeleteGroupRole;
using src.CQRS.GroupRole.Commands.UpdateGroupRole;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GroupRoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public GroupRoleController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.GroupRole.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateGroupRoleCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupRoleResponse => Created("", new Response<GroupRoleResponse>(groupRoleResponse)),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.GroupRole.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int groupRoleId,
            [FromBody] UpdateGroupRoleCommand command
        )
        {
            command.Id = groupRoleId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupRoleResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.GroupRole.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] int groupRoleId
        )
        {
            var deleteGroupRole = new DeleteGroupRoleCommand(groupRoleId);
            var result = await _mediator.Send(deleteGroupRole);

            return result.Match<IActionResult>(
                groupRoleResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}