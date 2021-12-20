namespace CourseApp
{
    using System;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var userInterfaceZoo = new UserInterfaceZoo();
            var zoo = new Zoo("Moscow zoo");
            var userInterfaceCalculate = new UserInterfaceCalculate();
            userInterfaceZoo.Draw(zoo);
            userInterfaceCalculate.StartPage();
            Console.ReadLine();
        }
    }
}
