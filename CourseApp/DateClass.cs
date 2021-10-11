namespace CourseApp
{
    using System;

    public class DateClass
    {
        public DateClass()
        {
            DateTime birthDay = new DateTime(2002, 04, 24);
            Console.WriteLine(StringBuilder(Age(birthDay)));
        }

        public (int, int, int) Age(DateTime birthDay)
        {
            DateTime dateToday = DateTime.Today;
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

        public string StringBuilder((int, int, int) age)
        {
            return $"Вам {GetDescription(age.Item1, "Year")}, {GetDescription(age.Item2, "Month")} и {GetDescription(age.Item3, "Day")}";
        }

        public string GetDescription(int item, string description)
        {
            var output = string.Empty;
            switch (description)
            {
                case "Year":
                    output = SetDescriptionYear(item);
                    break;

                case "Month":
                    output = SetDescriptionMonth(item);
                    break;

                case "Day":
                    output = SetDescriptionDay(item);
                    break;
            }

            return output;
        }

        public string SetDescriptionYear(int item)
        {
            var output = string.Empty;
            if (item % 10 == 1)
            {
                output += $"{item} год";
            }
            else
            {
                if (item % 10 > 1 && item % 10 < 3)
                {
                    output += $"{item} года";
                }
                else
                {
                    output += $"{item} лет";
                }
            }

            return output;
        }

        public string SetDescriptionMonth(int item)
        {
            var output = string.Empty;
            if (item % 10 == 1)
            {
                output += $"{item} месяц";
            }
            else
            {
                if (item % 10 > 1 && item % 10 < 3)
                {
                    output += $"{item} месяца";
                }
                else
                {
                    output += $"{item} месяцев";
                }
            }

            return output;
        }

        public string SetDescriptionDay(int item)
        {
            var output = string.Empty;
            if (item % 10 == 1)
            {
                output += $"{item} день";
            }
            else
            {
                if (item % 10 > 1 && item % 10 < 3)
                {
                    output += $"{item} дня";
                }
                else
                {
                    output += $"{item} дней";
                }
            }

            return output;
        }
    }
}