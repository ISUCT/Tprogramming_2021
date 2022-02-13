namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.GameBuilder;
    using CourseApp.RPGSaga.Generators;
    using CourseApp.RPGSaga.Heroes;
    using Kantaiko.ConsoleFormatting;

    public class Program
    {
        public static void Main(string[] args)
        {
            var pfabric = new PlayerFabric();
            var p1 = pfabric.FactoryMethod();
            var p2 = pfabric.FactoryMethod();
            var fight = new FightBuilder(p1, p2);
            fight.SetTragets();
            fight.StartFight();
        }
    }
}
