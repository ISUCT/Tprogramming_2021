namespace CourseApp
{
    using System;

    public class DateClass
    {
        public (int, int, int) CalculateAge(DateTime birthDay, DateTime dateToday)
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

        public (int, int) CalculateDaysToBirthDay(DateTime birthDay, DateTime dateToday)
        {
            var months = birthDay.Month - dateToday.Month;
            var years = birthDay.Year - dateToday.Year;
            if (birthDay.Year < dateToday.Day)
            {
                months--;
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            var days = (birthDay - dateToday.AddMonths((years * 12) + months)).Days;
            return (months, days);
        }
    }
}
