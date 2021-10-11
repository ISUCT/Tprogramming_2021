namespace CourseApp
{
    using System;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var userInterface = new UserInterface();
            userInterface.StartProgram();
            Console.ReadLine();
        }
    }
}