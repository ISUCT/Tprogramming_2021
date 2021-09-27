using AkvelonSaga.Core;
using AkvelonSaga.Core.Roles;
using AkvelonSaga.Server.Services;

namespace AkvelonSaga.Server.Configuration
{
    public sealed class PackageConfiguration : IPackageConfiguration
    {
        private readonly IRoleStorage _roleStorage;

        public PackageConfiguration(IRoleStorage roleStorage)
        {
            _roleStorage = roleStorage;
        }
        
        public void AddRole(string name, RoleFactory factory)
        {
            _roleStorage.AddRole(name, factory);
        }
    }
}
