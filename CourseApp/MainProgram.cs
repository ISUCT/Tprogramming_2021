namespace CourseApp
{
    using System;
    using CourseApp.Program.Interface;
    using CourseApp.Program.Zoo;

    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var zoo = new Zoo("Moscow zoo");
            var userInterface = new UserInterface();
            userInterface.Draw(zoo);
            Console.ReadLine();
        }
    }
}
