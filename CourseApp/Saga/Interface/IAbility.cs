namespace CourseApp.Saga.Interface
{
    public interface IAbility
    {
        int Loss { get; set; }

        string Name { get; }

        bool IsFreese { get; }

        bool IsFire { get; }

        bool IsPoison { get; }
    }
}