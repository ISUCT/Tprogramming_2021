namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class Attack : IAbility
    {
        public Attack(int damage)
        {
            Name = "Attack";
            Damage = damage;
            IsSkipRound = false;
            ActionDuration = 1;
            NumOfUses = 100000000;
            IsFire = false;
        }

        public int Damage { get; set; }

        public string Name { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; set; }

        public int NumOfUses { get; set; }

        public bool IsFire { get; }

        public override string ToString()
        {
            return $"base attack";
        }
    }
}