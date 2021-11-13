using System.Collections.Immutable;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.Abstractions
{
    internal interface IRoleStorage
    {
        ImmutableArray<string> Roles { get; }

        void AddRole(string name, RoleFactory factory);

        RoleFactory? GetRoleFactory(string role);
    }
}
