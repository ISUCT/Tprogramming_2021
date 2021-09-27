using System;
using System.Collections.Generic;
using System.Linq;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.Services
{
    public sealed class RandomPlayerFactory : IRandomPlayerFactory
    {
        private static readonly Random Random = new();
        
        private readonly IRoleStorage _roleStorage;
        private readonly IRandomNameGenerator _nameGenerator;

        public RandomPlayerFactory(IRoleStorage roleStorage, IRandomNameGenerator nameGenerator)
        {
            _roleStorage = roleStorage;
            _nameGenerator = nameGenerator;
        }
        
        public Player Create()
        {
            var name = _nameGenerator.Generate();
            var health = Random.Next(50, 70);
            var attack = Random.Next(10, 20);

            var roleName = _roleStorage.Roles.ElementAt(Random.Next(0, _roleStorage.Roles.Count));
            var roleFactory = _roleStorage.GetRoleFactory(roleName);

            if (roleFactory is null)
            {
                throw new KeyNotFoundException($"Role {roleName} not registered");
            }
            
            return roleFactory.Invoke(name, health, attack);
        }
    }
}
