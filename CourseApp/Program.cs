namespace CourseApp
{
    using CourseApp.RPGSaga.GameBuilder;

    public class Program
    {
        public static void Main(string[] args)
        {
            var gameBuilder = new GameBuilder(4);
            gameBuilder.StartTournament();
            gameBuilder.GetWinner();
        }
    }
}
