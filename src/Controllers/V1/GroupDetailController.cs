using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.GroupDetail;
using src.CQRS.GroupDetail.Commands.CreateGroupDetail;
using src.CQRS.GroupDetail.Commands.DeleteGroupDetail;
using src.CQRS.GroupDetail.Commands.UpdateGroupDetail;
using src.CQRS.GroupDetail.Queries;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GroupDetailController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GroupDetailController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.GroupDetail.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateGroupDetailCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupDetailResponse => Created(
                    "",
                    new Response<List<GroupDetailResponse>>(
                        groupDetailResponse
                    )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.GroupDetail.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int groupDetailId,
            [FromBody] UpdateGroupDetailCommand command
        )
        {
            command.Id = groupDetailId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                groupDetailResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.GroupDetail.Delete)]
        public async Task<IActionResult> Delete(
           [FromRoute] int groupDetailId
        )
        {
            var deleteGroupDetail = new DeleteGroupDetailCommand(groupDetailId);
            var result = await _mediator.Send(deleteGroupDetail);

            return result.Match<IActionResult>(
                groupDetailResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GroupDetail.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllGroupDetailQuery query
        )
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(
                    new Response<PagedResponse<GroupDetailResponse>>(
                        data
                    )
                ),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.GroupDetail.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] int groupDetailId
        )
        {
            var getGroupDetailById = new GetGroupDetailByIdQuery(groupDetailId);
            var result = await _mediator.Send(getGroupDetailById);

            return result.Match<IActionResult>(
                groupDetailResponse => Ok(new Response<GroupDetailResponse>(groupDetailResponse)),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}