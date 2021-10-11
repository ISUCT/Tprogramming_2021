namespace CourseApp
{
    using System;

    public class DateClass
    {
        public (int, int, int) Age(DateTime birthDay, DateTime dateToday)
        {
            var months = dateToday.Month - birthDay.Month;
            var years = dateToday.Year - birthDay.Year;
            if (dateToday.Day < birthDay.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            var days = (dateToday - birthDay.AddMonths((years * 12) + months)).Days;
            return (years, months, days);
        }

        public (string, string, string) StringBuilder((int, int, int) age)
        {
            var years = $"{age.Item1} year{(age.Item1 % 10 == 1 ? " " : "`s")}";
            var months = $"{age.Item2} month{(age.Item2 % 10 == 1 ? " " : "`s")}";
            var days = $"{age.Item3} day{(age.Item3 % 10 == 1 ? " " : "`s")}";
            return (years, months, days);
        }
    }
}