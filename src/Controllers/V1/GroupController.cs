using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Group;
using src.CQRS.Group.Commands.CreateGroup;
using src.CQRS.Group.Commands.DeleteGroup;
using src.CQRS.Group.Commands.UpdateGroup;
using src.CQRS.Group.Queries;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Group.Create)]
        public async Task<IActionResult> Create([FromBody] CreateGroupCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupResponse => Created("", new Response<GroupResponse>(
                    groupResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.Group.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid groupId,
            [FromBody] UpdateGroupCommand command
        )
        {
            command.Id = groupId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.Group.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid groupId
        )
        {
            var deleteGroup = new DeleteGroupCommand(groupId);
            var result = await _mediator.Send(deleteGroup);

            return result.Match<IActionResult>(
                groupResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Group.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid groupId
        )
        {
            var getGroupById = new GetGroupByIdQuery(groupId);
            var result = await _mediator.Send(getGroupById);

            return result.Match<IActionResult>(
                groupResponse => Ok(new Response<GroupResponse>(groupResponse)),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Group.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllGroupQuery query
        )
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(
                    new Response<PagedResponse<GroupResponse>>(
                        data
                    )
                ),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}