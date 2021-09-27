using System.Collections.Generic;

namespace AkvelonSaga.Core.Roles
{
    public interface IRoleStorage
    {
        IReadOnlyCollection<string> Roles { get; }

        void AddRole(string name, RoleFactory factory);

        RoleFactory? GetRoleFactory(string role);
    }
}
