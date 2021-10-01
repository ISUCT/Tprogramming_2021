using System;
using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Skills
{
    public sealed class BewitchingSkill : ISkill
    {
        public void Apply(IPlayerState sender, IPlayerState target)
        {
            Console.WriteLine($"{sender.Player.Name} применяет [Заворожение]");
        }
    }
}
