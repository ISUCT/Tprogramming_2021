using AkvelonSaga.Server.Abstractions;
using AkvelonSaga.Server.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Kantaiko.Hosting.Modules;
using AkvelonSaga.Server.GameProcess;
using AkvelonSaga.Server.Services;
using Microsoft.Extensions.Logging;

namespace AkvelonSaga.Server
{
    internal sealed class GameModule : IModule
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(c => c.ClearProviders());
            
            services.AddSingleton<Game>();
            services.AddSingleton<GameConfiguration>();
            
            services.AddSingleton<IRoleStorage, RoleStorage>();
            services.AddSingleton<ISkillStorage, SkillStorage>();
            
            services.AddSingleton<IRandomNameGenerator, RandomNameGenerator>();
            services.AddSingleton<IRandomPlayerFactory, RandomPlayerFactory>();
        }
    }
}
