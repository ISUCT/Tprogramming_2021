namespace CourseApp
{
    using System;
    using CourseApp.Program;

    public class MainFileClass
    {
        public static void Main(string[] args)
        {
            var userInterfaceClass = new UserInterfaceClass();
            userInterfaceClass.StartPage();
            Console.ReadLine();
        }
    }
}
