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

        public double Multiplier { get; }

        public override string ToString()
        {
            return $"vengeance strike";
        }
    }
}