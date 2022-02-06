namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class Spellbinding : IAbility
    {
        public Spellbinding()
        {
            Name = "Spellbinding";
            IsPositive = false;
            IsSkipRound = true;
            ActionDuration = 1;
            NumOfUses = 1;
            Multiplier = 0;
        }

        public string Name { get; }

        public bool IsPositive { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; }

        public int NumOfUses { get; }

        public double Multiplier { get; }
    }
}