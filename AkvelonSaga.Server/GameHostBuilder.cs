using System;
using System.Threading.Tasks;
using Kantaiko.Hosting.Host;
using Microsoft.Extensions.DependencyInjection;
using AkvelonSaga.Server.Configuration;
using AkvelonSaga.Server.GameProcess;

namespace AkvelonSaga.Server
{
    internal static class GameHostBuilder
    {
        public static async Task ConfigureAndRunAsync(Action<GameConfiguration>? configure = null)
        {
            var hostBuilder = new ManagedHostBuilder();

            hostBuilder.Modules.Add<GameModule>();

            var host = hostBuilder.Build();
            await host.StartAsync();

            if (!host.IsStarted)
            {
                throw new Exception("Failed to start server");
            }

            if (configure is not null)
            {
                var configuration = host.Services.GetRequiredService<GameConfiguration>();
                configure.Invoke(configuration);
            }

            var game = host.Services.GetRequiredService<Game>();
            await game.StartSessionAsync(2);

            await host.WaitForShutdownAsync();
        }
    }
}
