using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.GroupCost;
using src.CQRS.GroupCost.Commands.CreateGroupCost;
using src.CQRS.GroupCost.Commands.DeleteGroupCost;
using src.CQRS.GroupCost.Commands.UpdateGroupCost;
using src.CQRS.GroupCost.Queries;

namespace src.Controllers.V1
{
    public class GroupCostController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GroupCostController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.GroupCost.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateGroupCostCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupCostResponse => Created(
                    "",
                    new Response<GroupCostResponse>(
                        groupCostResponse
                    )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.GroupCost.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int groupCostId,
            [FromBody] UpdateGroupCostCommand command
        )
        {
            command.Id = groupCostId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupCostResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.GroupCost.Delete)]
        public async Task<IActionResult> Delete(
           [FromRoute] int groupCostId
        )
        {
            var deleteGroupCost = new DeleteGroupCostCommand(groupCostId);
            var result = await _mediator.Send(deleteGroupCost);

            return result.Match<IActionResult>(
                groupCostResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GroupCost.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllGroupCostQuery query
        )
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(
                    new Response<PagedResponse<GroupCostResponse>>(
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