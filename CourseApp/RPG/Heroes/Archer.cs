namespace CourseApp
{
    public class Archer : Player
    {
        public Archer(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassHero = "Windranger";
            NameUlt = "Быстрая атака fire arrows";
        }

        public override int Ultimate(Player unit, Player rival)
        {
            DamageUlt = 5;
            Logger.LoggerOutput($"{ClassHero}{Name} использовал ult способность{NameUlt}.");
            return Strength += DamageUlt;
        }

        public override string InfoOutput()
        {
            return "Герой: {ClassPlayer} ; Имя юнита: {Name} ; Здоровье юнита: {Health} ; Сила юнита {Strength}";
        }
    }
}