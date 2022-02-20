namespace CourseApp
{
    public class Mage : Player
    {
        public Mage(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassHero = "Skywrath mage";
            NameUlt = "Удар с небес";
        }

        public override int Ultimate(Player unit, Player rival)
        {
            DamageUlt = 6;
            Logger.LoggerOutput($"{ClassHero}{Name} использовал ult способность{NameUlt}.");
            return Strength += DamageUlt;
        }

        public override string InfoOutput()
        {
            return "Герой: {ClassPlayer} ; Имя юнита: {Name} ; Здоровье юнита: {Health} ; Сила юнита {Strength}";
        }
    }
}