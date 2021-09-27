﻿using System;
using System.Collections.Generic;
using AkvelonSaga.Core;

namespace AkvelonSaga.Server.Abstractions
{
    public interface ISkillStorage
    {
        void AddSkill<TRole, TSkill>()
            where TRole : Player
            where TSkill : ISkill, new();

        IEnumerable<ISkill> GetSkills(Type roleType);
    }
}
