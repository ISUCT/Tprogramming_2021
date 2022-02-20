namespace CourseApp
{
    using System;

    public class Archer : Player
    {
        public Archer(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassPlayer = "Лучник";
            UltimateName = "Ядовитая стрела";
        }

        public override int Ultimate(Player player, Player rival)
        {
            UltimateDamage = 2;
            Logger.LoggerOutput($"{ClassPlayer} {Name} использовал особую способность {UltimateName}!");
            return Strength += UltimateDamage;
        }

        public override string InfoOutput()
        {
            return $"Призвание: {ClassPlayer} ; Имя бойца: {Name} ; Здоровье бойца: {Health} ; Сила бойца {Strength}";
        }
    }
} 