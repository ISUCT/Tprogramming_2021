using System;
using AkvelonSaga.Core;

namespace AkvelonSaga.DLCs.Rogue.Skills
{
    public sealed class RetaliationStrikeSkill : ISkill
    {
        public void Apply(Player sender, Player target)
        {
            Console.WriteLine($"{sender.Name} применяет [Удар возмездия]");
        }
    }
}
