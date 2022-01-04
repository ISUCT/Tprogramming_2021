namespace CourseApp
{
    using System;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var dateClass = new DateClass();
            var birthDay = new DateTime(2001, 1, 2);
            var dateToday = DateTime.Today;
            var date = dateClass.CalculateAge(birthDay, dateToday);
            var days = dateClass.CalculateDaysToBirthDay(birthDay, dateToday);
            Console.WriteLine($"Your age: {date.Item1} y, {date.Item2} m and {date.Item3} d");
            Console.WriteLine($"Days to bd: {days.Item1} m, {days.Item2} d");
            Console.ReadLine();
        }
    }
}
