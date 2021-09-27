using AkvelonSaga.Core;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.Configuration
{
    internal sealed class GameConfiguration
    {
        private readonly IRoleStorage _roleStorage;
        private readonly ISkillStorage _skillStorage;

        public GameConfiguration(IRoleStorage roleStorage, ISkillStorage skillStorage)
        {
            _roleStorage = roleStorage;
            _skillStorage = skillStorage;
        }

        public void AddPackage<TPackage>() where TPackage : IGamePackage, new()
        {
            var packageConfiguration = new PackageConfiguration(_roleStorage, _skillStorage);
            var package = new TPackage();

            package.Configure(packageConfiguration);
        }
    }
}
