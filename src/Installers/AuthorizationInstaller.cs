using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace src.Installers
{
    public class AuthorizationInstaller : IInstaller
    {
        public void InstallServices(
            IConfiguration configuration,
            IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
            });
        }
    }
}