namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Exam;
    using CourseApp.Zoo;

    public class Program
    {
        public static void Main(string[] args)
        {
            var userInterface = new UserInterface();
            var zoo = new ZooClass("Dota 2");
            userInterface.Draw(zoo);
        }
    }
}