namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class FireArrows : IAbility
    {
        private bool _isFire;

        public FireArrows()
        {
            Name = "Fire arrows";
            IsPositive = false;
            IsSkipRound = false;
            ActionDuration = 100000;
            NumOfUses = 1;
            _isFire = true;
        }

        public string Name { get; }

        public bool IsPositive { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; }

        public int NumOfUses { get; }
    }
}