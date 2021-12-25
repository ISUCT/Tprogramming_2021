namespace CourseApp
{
    using System;

    public class PersonAgeCalculator
    {
        public string CalculatingAge(DateTime born)
        {
            return CalculatingAge(born, DateTime.Today);
        }

        public string CalculatingAge(DateTime born, DateTime end)
        {
            DateTime date = DateTime.MinValue.AddTicks(end.Ticks - born.Ticks);
            if ((date.Day - 2) == 0 && (date.Month - 1) == 0)
            {
                return "You are " + (date.Year - 1) + "th" + " years.";
            }
            else
            {
                return "You are " + (date.Year - 1) + " years, " + (date.Month - 1) + " months and " + (date.Day - 2) + " days";
            }
        }

        public void CakeIsALie()
        {
            Console.WriteLine(
                "┈┈┈☆☆☆☆☆☆☆┈┈┈" +
    "┈┈╭┻┻┻┻┻┻┻┻┻╮┈┈" +
    "┈┈┃╱╲╱╲╱╲╱╲╱┃┈┈" +
    "┈╭┻━━━━━━━━━┻╮┈" +
    "┈┃╱╲╱╲╱╲╱╲╱╲╱┃┈" +
    "┈┗━━━━━━━━━━━┛┈");
        }
    }
}
