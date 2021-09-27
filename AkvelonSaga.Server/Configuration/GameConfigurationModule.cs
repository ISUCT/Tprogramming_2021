using AkvelonSaga.Core.Roles;
using Microsoft.Extensions.DependencyInjection;
using Kantaiko.Hosting.Modules;
using AkvelonSaga.Server.GameProcess;
using AkvelonSaga.Server.Services;
using Microsoft.Extensions.Logging;

namespace AkvelonSaga.Server.Configuration
{
    internal sealed class GameConfigurationModule : IModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(c => c.ClearProviders());
            
            services.AddSingleton<Game>();
            services.AddSingleton<GameConfiguration>();
            
            services.AddSingleton<IRoleStorage, RoleStorage>();
        }
    }
}
