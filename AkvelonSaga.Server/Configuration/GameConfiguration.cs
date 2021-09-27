using AkvelonSaga.Core;
using AkvelonSaga.Server.Services;

namespace AkvelonSaga.Server.Configuration
{
    public sealed class GameConfiguration
    {
        private readonly IRoleStorage _roleStorage;

        public GameConfiguration(IRoleStorage roleStorage)
        {
            _roleStorage = roleStorage;
        }

        public void AddPackage<TPackage>() where TPackage : IGamePackage, new()
        {
            var packageConfiguration = new PackageConfiguration(_roleStorage);
            var package = new TPackage();

            package.Configure(packageConfiguration);
        }
    }
}
