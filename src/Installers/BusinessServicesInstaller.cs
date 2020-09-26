using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using src.Services;

namespace src.Installers
{
    public class BusinessServicesInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<ITourCategoryService, TourCategoryService>();
            services.AddScoped<IIdentityService, IdentityService>();
        }
    }
}