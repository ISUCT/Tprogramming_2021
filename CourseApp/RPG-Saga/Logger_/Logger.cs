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

        public static void AbilityLog(string sourceName, string sourceRole, string targetName, string targetRole, string abilityName)
        {
                Console.WriteLine($"{sourceName}({sourceRole}) применяет способность {abilityName} против {targetName}({targetRole})!\n");
        }

        public static void GettingDamage(string name, string role, string abilityName, double damage)
        {
            Console.WriteLine($"Игрок {name}({role}) получает {damage} урона от способности {abilityName}!\n");
        }

        public static void Death(string looser, string looserRole, string winner, string winnerRole)
        {
            Console.WriteLine($"Игрок {looser}({looserRole}) убит, побеждает игрок {winner}({winnerRole})!\n" +
                $"+--------------------------------------------------------------+\n");
        }

        public static void IsStunned(string name, string role)
        {
            Console.WriteLine($"Игрок {name}({role}) пропускает ход!\n");
        }
    }
}
