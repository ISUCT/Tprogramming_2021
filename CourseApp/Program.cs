namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.RPGSaga.GameBuilder;
    using CourseApp.RPGSaga.Heroes;
    using Kantaiko.ConsoleFormatting;

    public class Program
    {
        public static void Main(string[] args)
        {
            var tournam = new GameBuilder();
            tournam.StartTournament();
            tournam.GetWinner();
        }
    }
}
