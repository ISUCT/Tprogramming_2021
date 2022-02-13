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
            Console.WriteLine($"Your age: {date.Item1} year, {date.Item2} month and {date.Item3} day");
            Console.WriteLine($"Days to bd: {days.Item1} month, {days.Item2} day");
            Console.ReadLine();
        }
    }
}
