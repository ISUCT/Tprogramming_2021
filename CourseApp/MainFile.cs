namespace CourseApp
{
    using System;
    using CourseApp.Program;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var userInterfaceDate = new UserInterfaceDate();
            userInterfaceDate.StartPage();
            Console.ReadLine();
        }
    }
}
