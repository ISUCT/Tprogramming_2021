namespace CourseApp
{
    using System;

    public class Fighting
    {
        private readonly Random random = new Random();
        private int oneCounter = 0;
        private int twoCounter = 0;

        public Tuple<Player, Player> BattleCup(Player unit, Player unitRival)
        {
            while ((unit.Health > 0) && (unitRival.Health > 0))
            {
                if ((random.Next(1, 5) == 1) && (unit.EffectAbility == false) && (oneCounter != 1))
                {
                    oneCounter = 1;
                    unit.EffectAbility = true;
                }

                if ((random.Next(1, 5) == 2) && (unitRival.EffectAbility == false) && (twoCounter != 2))
                {
                    twoCounter = 2;
                    unitRival.EffectAbility = true;
                }

                if ((unit.Afk > 0) && (unit.Health > 0))
                {
                    Logger.LoggerOutput($"{unit.Name} немного афк!");
                    unit.Afk--;
                }
                else if (unit.Health > 0)
                {
                    unitRival.GetDamage(unit.AttackingUnit(unit, unitRival));
                    Logger.LoggerOutput($"{unitRival.Name} потерял {unit.InfoDamage} hp от тычки {unit.Name}!");
                }

                if ((unitRival.Afk > 0) && (unitRival.Health > 0))
                {
                    Logger.LoggerOutput($"{unitRival.Name} немного aфк");
                    unitRival.Afk--;
                }
                else if (unitRival.Health > 0)
                {
                    unit.GetDamage(unitRival.AttackingRival(unit, unitRival));
                    Logger.LoggerOutput($"{unit.Name} потерял {unitRival.InfoDamage} hp тычки {unitRival.Name}!");
                }
            }

            oneCounter = 0;
            twoCounter = 0;
            return new Tuple<Player, Player>(unit, unitRival);
        }
    }
}