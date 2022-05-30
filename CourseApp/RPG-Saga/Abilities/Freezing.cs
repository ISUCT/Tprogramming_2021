namespace CourseApp.RPG_Saga.Abilities
{
    using CourseApp.RPG_Saga.Interfaces;

    public class Freezing : IAbility
    {
        public Freezing()
        {
            Name = "Freezing";
            Damage = 0;
            DamagePerTurn = 0;
            DamageMultiplyer = 0;
            BasicDuration = 1;
            CurrentDuration = BasicDuration;
            BasicNumberOfUses = -1;
            NumberOfUses = BasicNumberOfUses;
            IsStunning = true;
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
