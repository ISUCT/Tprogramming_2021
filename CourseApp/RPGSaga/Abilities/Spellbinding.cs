namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class Spellbinding : IAbility
    {
        public Spellbinding()
        {
            Damage = 0;
            Name = "Spellbinding";
            IsSkipRound = true;
            ActionDuration = 1;
            NumOfUses = 1;
            Multiplier = 0;
            IsFire = false;
        }

        public int Damage { get; set; }

        public string Name { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; set; }

        public int NumOfUses { get; set; }

        public bool IsFire { get; }

        public double Multiplier { get; }

        public override string ToString()
        {
            return $"spellbinding";
        }
    }
}