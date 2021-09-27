using System;
using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Skills
{
    public sealed class BewitchingSkill : ISkill
    {
        public void Apply(Player sender, Player target)
        {
            Console.WriteLine($"{sender.Name} применяет [Заворожение]");
        }
    }
}
