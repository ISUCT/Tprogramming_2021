namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class UserInterface
    {
        public UserInterface()
        {
            Console.WriteLine("Hello!");
        }

        public bool IsFileCreated { get; set; }

        public void StartProgram()
        {
            var input = new InputValues();
            IsFileCreated = false;
            Console.Clear();
            Console.WriteLine(@"In this program you can:
1 - 
2 - 
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    DefaultFilePage();
                    break;

                case 2:
                    CustomFilePage();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void DefaultFilePage()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"Available actions:
1 - 
2 - Back to start page
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:

                    break;

                case 2:
                    StartProgram();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void CustomFilePage()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"Available actions:
1 - 
2 - 
3 - Back to start page
4 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 4))
            {
                case 1:

                    break;

                case 2:

                    break;

                case 3:
                    StartProgram();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}