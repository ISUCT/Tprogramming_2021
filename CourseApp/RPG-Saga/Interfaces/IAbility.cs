namespace CourseApp.RPG_Saga.Interfaces
{
    public interface IAbility
    {
        string Name { get; set; }

        double Damage { get; set; }

        int BasicDuration { get; set; }

        int CurrentDuration { get; set; }

        bool IsUsed { get; set; }

        bool IsAvailable { get; set; }

        void Cast(Player source, Player target);
    }
}
