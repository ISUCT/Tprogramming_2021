using System.Collections.Generic;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.Abstractions
{
    internal interface IRoleStorage
    {
        IReadOnlyCollection<string> Roles { get; }

        void AddRole(string name, RoleFactory factory);

        RoleFactory? GetRoleFactory(string role);
    }
}
