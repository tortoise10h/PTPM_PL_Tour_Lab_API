using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using src.Helpers;
using src.Services;

namespace src.Installers
{
    public class BusinessServicesInstaller : IInstaller
    {
        public void InstallServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IPaginationHelpers, PaginationHelpers>();
            services.AddScoped<ITourCategoryService, TourCategoryService>();
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
            services.AddScoped<ITourDetailService, TourDetailService>();
            services.AddScoped<ITourPricesService, TourPricesService>();
            services.AddScoped<ITourService, TourService>();
            services.AddScoped<IGroupService, GroupService>();
        }
    }
}