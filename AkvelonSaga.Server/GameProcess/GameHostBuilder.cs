using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Kantaiko.Hosting.Host;
using AkvelonSaga.Server.Configuration;

namespace AkvelonSaga.Server.GameProcess
{
    public sealed class GameHostBuilder
    {
        private readonly ManagedHostBuilder _hostBuilder = new();

        public GameHostBuilder()
        {
            _hostBuilder.Modules.Add<GameConfigurationModule>();
        }

        public IManagedHost Build()
        {
            return _hostBuilder.Build();
        }

        public static async Task ConfigureAndRunAsync(Action<GameConfiguration>? configure = null)
        {
            var host = new GameHostBuilder().Build();
            host.Start();

            if (!host.IsStarted)
            {
                throw new Exception("Failed to start game");
            }

            if (configure is not null)
            {
                var configuration = host.Services.GetRequiredService<GameConfiguration>();
                configure.Invoke(configuration);
            }
            
            var game = host.Services.GetRequiredService<Game>();
            game.StartSession(4);
            
            await host.WaitForShutdownAsync();
        }
    }
}
