namespace CourseApp.RPGSaga.Interfaces
{
    public interface IAbility
    {
        int Damage { get; set; }

        string Name { get; }

        bool IsSkipRound { get; }

        int ActionDuration { get; set; }

        int NumOfUses { get; set; }

        bool IsFire { get; }
    }
}