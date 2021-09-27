using AkvelonSaga.Core.Roles;

namespace AkvelonSaga.Core
{
    public sealed class PackageConfiguration
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
