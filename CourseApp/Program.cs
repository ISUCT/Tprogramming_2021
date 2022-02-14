namespace CourseApp
{
    using System;
    using CourseApp.RPGSaga.GameBuilder;
    using CourseApp.RPGSaga.Generators;

    public class Program
    {
        public static void Main(string[] args)
        {
            var playerFactory = new PlayerFabric();
            var playerOne = playerFactory.FactoryMethod();
            var playerTwo = playerFactory.FactoryMethod();
            var fight = new FightBuilder(playerOne, playerTwo);
            fight.SetTargets();
            Console.WriteLine(fight.StartFight());
        }
    }
}
