namespace CourseApp
{
    public class Archer : Player
    {
        public Archer(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassHero = "Windranger";
            NameUlt = "������� ����� fire arrows";
        }

        public override int Ultimate(Player unit, Player rival)
        {
            DamageUlt = 5;
            Logger.LoggerOutput($"{ClassHero}{Name} ����������� ult �����������{NameUlt}.");
            return Strength += DamageUlt;
        }

        public override string InfoOutput()
        {
            return "�����: {ClassPlayer} ; ��� �����: {Name} ; �������� �����: {Health} ; ���� ����� {Strength}";
        }
    }
}