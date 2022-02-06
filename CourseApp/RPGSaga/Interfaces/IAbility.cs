namespace CourseApp.RPGSaga.Interfaces
{
    public interface IAbility
    {
        string Name { get; }

        bool IsPositive { get; }

        bool IsSkipRound { get; }

        int ActionDuration { get; }

        int NumOfUses { get; }
    }
}