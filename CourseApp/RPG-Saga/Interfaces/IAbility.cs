namespace CourseApp.RPG_Saga.Interfaces
{
    public interface IAbility
    {
        string Name { get; set; }

        double Damage { get; set; }

        double DamagePerTurn { get; set; }

        double DamageMultiplyer { get; set; }

        int BasicDuration { get; set; }

        int CurrentDuration { get; set; }

        int NumberOfUses { get; set; }

        int BasicNumberOfUses { get; set; }

        bool IsStunning { get; set; }

        bool IsUsed { get; set; }

        bool DoesWasteMove { get; set; }
    }
}
