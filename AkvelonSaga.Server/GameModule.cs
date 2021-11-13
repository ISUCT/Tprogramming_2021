using Kantaiko.Hosting.Modules;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using AkvelonSaga.Server.Configuration;
using AkvelonSaga.Server.Abstractions;
using AkvelonSaga.Server.GameProcess;
using AkvelonSaga.Server.Services;

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
