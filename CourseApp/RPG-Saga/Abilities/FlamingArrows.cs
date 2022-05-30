namespace CourseApp.RPG_Saga.Abilities
{
    using CourseApp.RPG_Saga.Interfaces;

    public class FlamingArrows : IAbility
    {
        public FlamingArrows()
        {
            Name = "FlamingArrows";
            Damage = 0;
            DamagePerTurn = 2.0;
            DamageMultiplyer = 0;
            BasicDuration = 100;
            CurrentDuration = BasicDuration;
            BasicNumberOfUses = 1;
            NumberOfUses = BasicNumberOfUses;
            IsStunning = false;
            IsUsed = false;
            DoesWasteMove = false;
        }

        public string Name { get; set; }

        public double Damage { get; set; }

        public double DamagePerTurn { get; set; }

        public double DamageMultiplyer { get; set; }

        public int BasicDuration { get; set; }

        public int CurrentDuration { get; set; }

        public int NumberOfUses { get; set; }

        public int BasicNumberOfUses { get; set; }

        public bool IsStunning { get; set; }

        public bool IsUsed { get; set; }

        public bool DoesWasteMove { get; set; }
    }
}
