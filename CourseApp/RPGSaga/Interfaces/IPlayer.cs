namespace CourseApp.RPGSaga
{
    public interface IPlayer
    {
        string Name { get; set; }

        int HP { get; set; }

        int Strength { get; set; }
    }
}