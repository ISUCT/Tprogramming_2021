namespace CourseApp
{
    public class Mage : Player
    {
        public Mage(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassHero = "Skywrath mage";
            NameUlt = "���� � �����";
        }

        public override int Ultimate(Player unit, Player rival)
        {
            DamageUlt = 6;
            Logger.LoggerOutput($"{ClassHero}{Name} ����������� ult �����������{NameUlt}.");
            return Strength += DamageUlt;
        }

        public override string InfoOutput()
        {
            return "�����: {ClassPlayer} ; ��� �����: {Name} ; �������� �����: {Health} ; ���� ����� {Strength}";
        }
    }
}