using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.StaffGroupRole;
using src.CQRS.StaffGroupRole.Commands.CreateStaffGroupRole;
using src.CQRS.StaffGroupRole.Commands.DeleteStaffGroupRole;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class StaffGroupRoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public StaffGroupRoleController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.StaffGroupRole.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateStaffGroupRoleCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                staffgroupRoleResponse => Created(
                    "",
                    new Response<StaffGroupRoleResponse>(
                        staffgroupRoleResponse
                    )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.StaffGroupRole.Delete)]
        public async Task<IActionResult> Delete(
           [FromRoute] int staffGroupRoleId
        )
        {
            var deleteStaffGroupRole = new DeleteStaffGroupRoleCommand(staffGroupRoleId);
            var result = await _mediator.Send(deleteStaffGroupRole);

            return result.Match<IActionResult>(
                staffGroupRoleResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}