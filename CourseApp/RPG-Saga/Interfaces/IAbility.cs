namespace CourseApp.RPG_Saga.Interfaces
{
    public interface IAbility
    {
        string Name { get; set; }

        int Damage { get; set; }

        int Duration { get; set; }
    }
}
