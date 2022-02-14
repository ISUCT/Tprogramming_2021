namespace CourseApp.RPGSaga.Abilities
{
    using CourseApp.RPGSaga.Interfaces;

    public class VengeanceStrike : IAbility
    {
        public VengeanceStrike(int damage)
        {
            Multiplier = 1.3;
            Damage = (int)(Multiplier * damage);
            Name = "Vengeance Strike";
            IsSkipRound = false;
            ActionDuration = 1;
            NumOfUses = 1;
            IsFire = false;
        }

        public int Damage { get; set; }

        public string Name { get; }

        public bool IsSkipRound { get; }

        public int ActionDuration { get; set; }

        public int NumOfUses { get; set; }

        public bool IsFire { get; }

        private double Multiplier { get; }

        public void SetDefaultValue()
        {
            ActionDuration = 1;
            NumOfUses = 1;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}