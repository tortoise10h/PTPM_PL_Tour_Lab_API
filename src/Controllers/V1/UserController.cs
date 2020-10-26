using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.User;
using src.CQRS.User.Queries;

namespace src.Controllers.V1
{
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.User.GetAll)]
        public async Task<IActionResult> GetAllCustomers(
            [FromQuery] GetAllCustomersQuery query
        )
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(
                    new Response<PagedResponse<UserResponse>>(
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