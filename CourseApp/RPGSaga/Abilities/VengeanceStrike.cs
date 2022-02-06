namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class VengeanceStrike : IAbility
    {
        public VengeanceStrike()
        {
            Multiplier = 1.3;
            Name = "Vengeance Strike";
            IsPositive = false;
            IsSkipRound = false;
            ActionDuration = 1;
            NumsPerRound = 1;
            NumOfUses = 1;
        }

        public string Name { get; }

        public bool IsPositive { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; }

        public int NumsPerRound { get; }

        public int NumOfUses { get; }

        public double Multiplier { get; }
    }
}