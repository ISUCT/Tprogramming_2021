using System;
using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Skills
{
    public sealed class RetaliationStrikeSkill : ISkill
    {
        public void Apply(PlayerState sender, PlayerState target)
        {
            Console.WriteLine($"{sender.Player.Name} применяет [Удар возмездия]");
        }
    }
}
