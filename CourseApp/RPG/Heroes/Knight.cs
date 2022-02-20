namespace CourseApp
{
    public class Knight : Player
    {
        public Knight(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassHero = "Dragon Knight";
            NameUlt = "Двойной удар";
        }

        public override int Ultimate(Player unit, Player rival)
        {
            DamageUlt = 3;
            Logger.LoggerOutput($"{ClassHero}{Name} использовал ult способность{NameUlt}.");
            return Strength += DamageUlt;
        }

        public override string InfoOutput()
        {
            return "Герой: {ClassPlayer} ; Имя юнита: {Name} ; Здоровье юнита: {Health} ; Сила юнита {Strength}";
        }
    }
}