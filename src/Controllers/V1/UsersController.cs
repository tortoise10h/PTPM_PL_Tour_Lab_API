using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.RequestModels.Auth;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Auth;
using src.Contracts.V1.ResponseModels.User;
using src.CQRS.Auth.Commands.Login;
using src.CQRS.User.Queries;
using src.Services;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsersController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public UsersController(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.User.GetAllCustomers)]
        public async Task<IActionResult> GetAllCustomers([FromQuery] GetAllCustomersQuery query)
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