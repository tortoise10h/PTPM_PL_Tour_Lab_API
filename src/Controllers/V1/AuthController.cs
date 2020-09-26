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
using src.Services;

namespace src.Controllers.V1
{
    public class AuthController : ControllerBase
    {
        private readonly IIdentityService _identityService;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public AuthController(IIdentityService identityService, IMapper mapper, IMediator mediator)
        {
            _identityService = identityService;
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Auth.Register)]
        public async Task<IActionResult> Register(
            [FromBody] UserRegistrationRequest registerInfo)
        {
            var registerResult = await _identityService.RegisterAsync(registerInfo);
            if (!registerResult.IsSuccess)
            {
                return BadRequest(registerResult.Errors);
            }

            var userResponse = _mapper.Map<UserResponse>(registerResult.EntityReturn);
            return Created("", new Response<UserResponse>(userResponse));
        }

        [HttpPost(ApiRoutes.Auth.Login)]
        public async Task<IActionResult> Login(
            [FromBody] LoginCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Errors);
            }

            return Ok(new Response<LoginResponse>(
                new LoginResponse
                {
                    Token = result.Token,
                    UserResponse = result.UserResponse,
                    TokenExpireTime = result.TokenExpireTime,
                    RefreshToken = result.RefreshToken
                }
            ));
        }
        // [HttpPost(ApiRoutes.Auth.Login)]
        // public async Task<IActionResult> Login(
        //     [FromBody] LoginRequest loginInfo)
        // {
        //     var loginResult = await _identityService.LoginAsync(
        //         loginInfo.Email,
        //         loginInfo.Password);

        //     if (!loginResult.IsSuccess)
        //     {
        //         return BadRequest(loginResult.Errors);
        //     }

        //     return Ok(new Response<LoginResponse>(
        //         new LoginResponse
        //         {
        //             Token = loginResult.Token,
        //             UserResponse = loginResult.UserResponse,
        //             TokenExpireTime = loginResult.TokenExpireTime,
        //             RefreshToken = loginResult.RefreshToken
        //         }
        //     ));
        // }

        [HttpGet(ApiRoutes.Auth.Profile)]
        public IActionResult GetProfile()
        {
            return Ok("Ok");
        }
    }
}