using AkvelonSaga.Core;
using AkvelonSaga.Core.Roles;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.Configuration
{
    public sealed class PackageConfiguration : IPackageConfiguration
    {
        private readonly IRoleStorage _roleStorage;
        private readonly ISkillStorage _skillStorage;

        public PackageConfiguration(IRoleStorage roleStorage, ISkillStorage skillStorage)
        {
            _roleStorage = roleStorage;
            _skillStorage = skillStorage;
        }
        
        public void AddRole(string name, RoleFactory factory)
        {
            _roleStorage.AddRole(name, factory);
        }

        public void AddSkill<TRole, TSkill>() where TRole : Player where TSkill : ISkill, new()
        {
            _skillStorage.AddSkill<TRole, TSkill>();
        }
    }
}
