namespace CourseApp
{
    using System;
    using CourseApp.Program;

    public class MainFileClass
    {
        public static void Main(string[] args)
        {
            var userInterface = new UserInterfaceClass();
            userInterface.StartPage();
            Console.ReadLine();
        }
    }
}
