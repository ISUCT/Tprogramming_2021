using AkvelonSaga.Core.Roles;

namespace AkvelonSaga.Core
{
    public interface IPackageConfiguration
    {
        void AddRole(string name, RoleFactory factory);
    }
}
