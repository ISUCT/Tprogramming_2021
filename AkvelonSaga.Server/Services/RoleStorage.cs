using System.Collections.Generic;
using AkvelonSaga.Core;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.Services
{
    public class RoleStorage : IRoleStorage
    {
        private readonly Dictionary<string, RoleFactory> _roleFactories = new();

        public IReadOnlyCollection<string> Roles => _roleFactories.Keys;

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
