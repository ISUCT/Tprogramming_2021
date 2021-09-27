using System.Collections.Generic;
using AkvelonSaga.Core.Roles;

namespace AkvelonSaga.Server.Abstractions
{
    public interface IRoleStorage
    {
        IReadOnlyCollection<string> Roles { get; }

        void AddRole(string name, RoleFactory factory);

        RoleFactory? GetRoleFactory(string role);
    }
}
