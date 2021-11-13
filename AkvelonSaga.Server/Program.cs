using System.Threading.Tasks;
using AkvelonSaga.DLCs.Rogue;

namespace AkvelonSaga.Server
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await GameHostBuilder.ConfigureAndRunAsync(configuration =>
            {
                configuration.AddPackage<RoguePackage>();
            });
        }
    }
}
