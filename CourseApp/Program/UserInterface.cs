namespace CourseApp.Program
{
    using System;
    using CourseApp.Program.Input;

    public class UserInterface
    {
        public UserInterface()
        {
            Console.WriteLine("Hello!");
            IsDateFilled = false;
        }

        public bool IsDateFilled { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public void StartProgram()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"
Avaible actions:
1 - Set your birthDay
2 - Get your age
3 - Get date to your birthDay
4 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    SetBirthDayPage();
                    break;

                case 2:
                    YourAgePage();
                    break;

                case 3:
                    DaysToBirthDay();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        public void Output(string message)
        {
            switch (message)
            {
                case "days":
                    var days = Date();
                    var line = string.Empty;
                    if (string.IsNullOrEmpty(days.Item1) && string.IsNullOrEmpty(days.Item2))
                    {
                        line = $"{days.Item3}";
                    }

                    if (!string.IsNullOrEmpty(days.Item1) && !string.IsNullOrEmpty(days.Item2))
                    {
                        line = $"{days.Item1}, {days.Item2} {days.Item3}";
                    }

                    if (string.IsNullOrEmpty(days.Item1) || string.IsNullOrEmpty(days.Item2))
                    {
                        if (string.IsNullOrEmpty(days.Item1))
                        {
                            line = $"{days.Item2} {days.Item3}";
                        }

                        if (string.IsNullOrEmpty(days.Item2))
                        {
                            line = $"{days.Item1} {days.Item3}";
                        }
                    }

                    Console.WriteLine(line);
                    break;

                case "age":
                    var age = Age();
                    Console.WriteLine($"Your age: {age.Item1}, {age.Item2} and {age.Item3}");
                    break;
            }
        }

        private void SetBirthDayPage()
        {
            Console.Clear();
            var input = new InputValues();
            Console.WriteLine("Enter your birthday");
            Console.WriteLine("Year:");
            Year = input.InputInt(0000, 9999);
            Console.WriteLine("Month:");
            Month = input.InputInt(1, 12);
            Console.WriteLine("Day:");
            Day = input.InputInt(1, 31);
            IsDateFilled = true;
            StartProgram();
        }

        private void YourAgePage()
        {
            Console.Clear();
            var input = new InputValues();
            if (IsDateFilled)
            {
                Output("age");
            }
            else
            {
                Console.WriteLine("You dont enter your birthDay!");
            }

            Console.WriteLine(@"
Avaible actions:
1 - Return to previous page
2 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    StartProgram();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private void DaysToBirthDay()
        {
            Console.Clear();
            var input = new InputValues();
            if (IsDateFilled)
            {
                Output("days");
            }
            else
            {
                Console.WriteLine("You dont enter your birthDay!");
            }

            Console.WriteLine(@"
Avaible actions:
1 - Return to previous page
2 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    StartProgram();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private (string, string, string) Age()
        {
            var dateClass = new DateClass();
            var birthDay = new DateTime(Year, Month, Day);
            var dateToday = DateTime.Today;
            var date = dateClass.CreateOutput(dateClass.CalculateAge(birthDay, dateToday));
            return (date.Item1, date.Item2, date.Item3);
        }

        private (string, string, string) Date()
        {
            var dateClass = new DateClass();
            var birthDay = new DateTime(Year, Month, Day);
            var dateToday = DateTime.Today;
            var date = dateClass.CreateOutput(dateClass.CalculateDaysToBirthDay(birthDay, dateToday));
            return (date.Item1, date.Item2, date.Item3);
        }
    }
}