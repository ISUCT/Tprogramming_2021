namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class FireArrows : IAbility
    {
        public FireArrows()
        {
            Damage = 0;
            Name = "Fire arrows";
            IsSkipRound = false;
            ActionDuration = 100000;
            NumOfUses = 1;
            IsFire = true;
        }

        public int Damage { get; set; }

        public string Name { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; set; }

        public int NumOfUses { get; set; }

        public bool IsFire { get; }

        public override string ToString()
        {
            return $"fire arrows";
        }
    }
}