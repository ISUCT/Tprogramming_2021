namespace CourseApp
{
    using System;

    public class Wizard : Player
    {
        public Wizard(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Чародей";
            UltimateName = "Каменный дождь";
        }

        public override int Ultimate(Player player, Player rival)
        {
            if (player.Effect)
            {
                player.Afk = 1;
                rival.Afk = 2;
            }
            else if (rival.Effect)
            {
                player.Afk = 2;
                rival.Afk = 1;
            }

            Logger.LoggerOutput($"{ClassPlayer} {Name} особую способность {UltimateName}!");
            return 0;
        }

        public override string InfoOutput()
        {
            return $"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
}