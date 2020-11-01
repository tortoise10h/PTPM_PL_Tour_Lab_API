using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Group;
using src.Contracts.V1.ResponseModels.GroupCost;
using src.Contracts.V1.ResponseModels.StaffGroupRole;
using src.Contracts.V1.ResponseModels.User;
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
            [FromRoute] int groupId,
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
            [FromRoute] int groupId
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
            [FromRoute] int groupId
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

        [HttpGet(ApiRoutes.Group.GetGroupCostsOfGroup)]
        public async Task<IActionResult> GetGroupCostsOfGroup
        (
            [FromRoute] int groupId,
            [FromQuery] GetGroupCostsOfGroup query
        )
        {
            query.GroupId = groupId;
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<GroupCostResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Group.GetStaffsOfGroup)]
        public async Task<IActionResult> GetStaffsOfGroup
        (
            [FromRoute] int groupId,
            [FromQuery] GetStaffsOfGroup query
        )
        {
            query.GroupId = groupId;
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<StaffGroupRoleResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Group.GetStaffsWithoutRoleOfGroup)]
        public async Task<IActionResult> GetStaffsWithoutRoleOfGroup
        (
            [FromRoute] int groupId,
            [FromQuery] GetStaffsWithoutRoleOfGroup query
        )
        {
            query.GroupId = groupId;
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<UserResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}