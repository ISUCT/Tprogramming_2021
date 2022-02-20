namespace CourseApp
{
    public class Knight : Player
    {
        public Knight(string name, double health, int strength)
        : base(name, health, strength)
        {
            ClassHero = "Dragon Knight";
            NameUlt = "������� ����";
        }

        public override int Ultimate(Player unit, Player rival)
        {
            DamageUlt = 3;
            Logger.LoggerOutput($"{ClassHero}{Name} ����������� ult �����������{NameUlt}.");
            return Strength += DamageUlt;
        }

        public override string InfoOutput()
        {
            return "�����: {ClassPlayer} ; ��� �����: {Name} ; �������� �����: {Health} ; ���� ����� {Strength}";
        }
    }
}