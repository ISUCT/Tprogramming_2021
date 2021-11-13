using System;
using System.Collections.Generic;
using System.Linq;
using AkvelonSaga.Core;
using AkvelonSaga.Server.Abstractions;

namespace AkvelonSaga.Server.Services
{
    internal sealed class SkillStorage : ISkillStorage
    {
        private readonly Dictionary<Type, List<ISkill>> _skills = new();
        
        public void AddSkill<TRole, TSkill>() 
            where TRole : Player 
            where TSkill : ISkill, new()
        {
            var skill = new TSkill();
            
            if (_skills.TryGetValue(typeof(TRole), out var skills))
            {
                skills.Add(skill);
                return;
            }
            
            _skills[typeof(TRole)] = new List<ISkill>
            {
                skill
            };
        }

        public IEnumerable<ISkill> GetSkills(Type roleType)
        {
            if (_skills.TryGetValue(roleType, out var skills))
            {
                return skills;
            }
            
            return Enumerable.Empty<ISkill>();
        }
    }
}
