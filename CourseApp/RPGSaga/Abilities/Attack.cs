namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class Attack : IAbility
    {
        public Attack()
        {
            Name = "Attack";
            IsPositive = false;
            IsSkipRound = false;
            ActionDuration = 1;
            NumOfUses = 100000000;
        }

        public string Name { get; }

        public bool IsPositive { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; }

        public int NumOfUses { get; }
    }
}