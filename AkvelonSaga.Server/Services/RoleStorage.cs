using System.Collections.Generic;
using System.Collections.Immutable;
using AkvelonSaga.Core;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.Services
{
    internal sealed class RoleStorage : IRoleStorage
    {
        private readonly Dictionary<string, RoleFactory> _roleFactories = new();

        public ImmutableArray<string> Roles => ImmutableArray.CreateRange(_roleFactories.Keys);

        public void AddRole(string name, RoleFactory factory)
        {
            _roleFactories[name] = factory;
        }

        public RoleFactory? GetRoleFactory(string role)
        {
            if (_roleFactories.TryGetValue(role, out var roleFactory))
            {
                return roleFactory;
            }

            return null;
        }
    }
}
