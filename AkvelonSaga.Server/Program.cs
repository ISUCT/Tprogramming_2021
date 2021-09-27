using System.Threading.Tasks;
using AkvelonSaga.Server.GameProcess;

namespace AkvelonSaga.Server
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await GameHostBuilder.ConfigureAndRunAsync();
        }
    }
}
