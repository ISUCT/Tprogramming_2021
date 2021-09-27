using Microsoft.Extensions.DependencyInjection;
using Kantaiko.Hosting.Modules;
using AkvelonSaga.Server.GameProcess;
using Microsoft.Extensions.Logging;

namespace AkvelonSaga.Server.Configuration
{
    internal sealed class GameConfigurationModule : IModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(c => c.ClearProviders());
            
            services.AddSingleton<Game>();
        }
    }
}
