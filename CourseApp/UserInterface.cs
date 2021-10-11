namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class UserInterface
    {
        public UserInterface()
        {
            Console.WriteLine("Hello!");
            IsDateFilled = false;
        }

        public bool IsDateFilled { get; set; }

        public string Age { get; set; }

        public void StartProgram()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"Avaible actions:
1 - Set your birthDay
2 - Get your age
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    BirthDayPage();
                    break;

                case 2:
                    AgePage();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void BirthDayPage()
        {
            Console.Clear();
            var input = new InputValues();
            Console.WriteLine("Enter your birthday");
            Console.WriteLine("Year:");
            var year = input.InputInt(0000, 9999);
            Console.WriteLine("Month:");
            var month = input.InputInt(1, 12);
            Console.WriteLine("Day:");
            var day = input.InputInt(1, 31);
            DateTime birthDay = new DateTime(year, month, day);
            DateTime dateToday = DateTime.Today;
            var dateClass = new DateClass();
            var age = dateClass.StringBuilder(dateClass.Age(birthDay, dateToday));
            Age = $"Your age: {age.Item1}, {age.Item2} and {age.Item3}";
            IsDateFilled = true;
            StartProgram();
        }

        private void AgePage()
        {
            Console.Clear();
            var input = new InputValues();
            if (IsDateFilled)
            {
                Console.WriteLine(Age);
            }
            else
            {
                Console.WriteLine("You dont enter your birthDay!");
            }

            Console.WriteLine(@"Avaible actions:
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
    }
}