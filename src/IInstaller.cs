using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace src
{
    public interface IInstaller
    {
        void InstallServices(IConfiguration configuration, IServiceCollection services);
    }
}