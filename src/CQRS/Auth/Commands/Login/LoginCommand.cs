using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using src.Contracts.V1.ResponseModels.Auth;
using src.Entities;
using src.Services;

namespace src.CQRS.Auth.Commands.Login
{
    public class LoginCommand : IRequest<LoginResult>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginHandler : IRequestHandler<LoginCommand, LoginResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IIdentityService _identityService;

        public LoginHandler(UserManager<ApplicationUser> userManager, IIdentityService identityService)
        {
            _userManager = userManager;
            _identityService = identityService;
        }
        public async Task<LoginResult> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null)
            {
                return new LoginResult
                {
                    IsSuccess = false,
                    Errors = new List<string>() {
                        "User does not exist"
                    }
                };
            }

            var userHasValidPassword = await _userManager.CheckPasswordAsync(user, request.Password);

            if (!userHasValidPassword)
            {
                return new LoginResult
                {
                    IsSuccess = false,
                    Errors = new List<string>() {
                        "Email or password is incorrect"
                    }
                };
            }

            return await _identityService.GenerateLoginResult(user);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}