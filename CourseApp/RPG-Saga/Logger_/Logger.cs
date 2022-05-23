namespace CourseApp.RPG_Saga.Logger_
{
    using System;

    public static class Logger
    {
        public static void RoundAnnouncement(int numOfRound)
        {
            Console.WriteLine($"Раунд {numOfRound}!\n" +
                $"+--------------------------------------------------------------+\n");
        }

        public static void FightAnnouncement(int numOfFight)
        {
            Console.WriteLine($"Бой {numOfFight}!\n" +
                $"+--------------------------------------------------------------+\n");
        }

        public static void DamageLog(string sourceName, string sourceRole, string targetName, string targetRole, double damage)
        {
            Console.WriteLine($"{sourceName}({sourceRole}) наносит {targetName}({targetRole}) {damage} урона!\n");
        }

        public static void AbilityLog(string sourceName, string sourceRole, string targetName, string targetRole, string abilityName, double damage)
        {
            if (damage > 0)
            {
                Console.WriteLine($"{sourceName}({sourceRole}) применяет способность {abilityName} и наносит {targetName}({targetRole}) {damage} урона!\n");
            }
            else
            {
                Console.WriteLine($"{sourceName}({sourceRole}) применяет способность {abilityName} против {targetName}({targetRole})!\n");
            }
        }

        public static void Death(string looser, string looserRole, string winner, string winnerRole)
        {
            Console.WriteLine($"Игрок {looser}({looserRole}) убит, побеждает игрок {winner}({winnerRole})!\n" +
                $"+--------------------------------------------------------------+\n");
        }
    }
}
