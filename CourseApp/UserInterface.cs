namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class UserInterface
    {
        public UserInterface()
        {
            Console.WriteLine("Hello!");
            IsFileCreated = false;
        }

        public bool IsFileCreated { get; set; }

        public void StartProgram()
        {
            var input = new InputValues();
            var customFile = new List<string>();
            Console.Clear();
            Console.WriteLine(@"In this program you can:
1 - Create default file
2 - Create custom file
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    DefaultFilePage();
                    break;

                case 2:
                    CustomFilePage(customFile);
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
1 - Get default file
2 - Back to start page
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    CreateDefaultFile();
                    break;

                case 2:
                    StartProgram();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void CustomFilePage(List<string> customFile)
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"Available actions:
1 - Get custom files
2 - Enter custom values
3 - Back to start page
4 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 4))
            {
                case 1:
                    GetCustomFiles(customFile);
                    break;

                case 2:
                    CustomFile(customFile);
                    break;

                case 3:
                    StartProgram();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;
            }
        }

        private void CreateDefaultFile()
        {
            var file = new FileCreator("Program", "Cs", 0.34, "MB");
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($@"Default file:
{file.Display()}");
            Console.WriteLine(@"
Available actions:
1 - Back to previous page
2 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    DefaultFilePage();
                    break;

                case 2:
                    Environment.Exit(0);
                    break;
            }
        }

        private void CreateCustomFile(List<string> customFile)
        {
            Console.Clear();
            var input = new InputValues();
            var file = new FileCreator(EnumValueName(), EnumValueExtension(), EnterValue(), EnumValueWeightModificator());
            customFile.Add(file.Display());
            IsFileCreated = true;
        }

        private void CustomFile(List<string> customFile)
        {
            var input = new InputValues();
            Console.Clear();
            CreateCustomFile(customFile);
            Console.Clear();
            Console.WriteLine(@"Available actions:
1 - Create another custom file
2 - Back to previous page
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 2))
            {
                case 1:
                    CustomFile(customFile);
                    break;

                case 2:
                    CustomFilePage(customFile);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private void GetCustomFiles(List<string> customFile)
        {
            var input = new InputValues();
            Console.Clear();
            if (IsFileCreated)
            {
                Console.WriteLine($"Your file{((customFile.Count == 1) ? ":" : "s:")}");
                for (int i = 0; i < customFile.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {customFile[i]}");
                }
            }
            else
            {
                Console.WriteLine("You dont create any files");
            }

            Console.WriteLine(@"
Available actions:
1 - Create custom file
2 - Back to previous page
3 - Exit program
What you want? Enter integer values.");
            switch (input.InputInt(1, 3))
            {
                case 1:
                    CustomFile(customFile);
                    break;

                case 2:
                    CustomFilePage(customFile);
                    break;

                case 3:
                    Environment.Exit(0);
                    break;
            }
        }

        private string EnumValueName()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Choose name. Enter integer values.");
            for (int i = 0; i < Enum.GetNames(typeof(EnumName)).Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumName), i)}");
            }

            return Enum.GetName(typeof(EnumName), input.InputInt(1, Enum.GetNames(typeof(EnumName)).Length) - 1);
        }

        private string EnumValueExtension()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Choose extension. Enter integer values.");
            for (int i = 0; i < Enum.GetNames(typeof(EnumExtension)).Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumExtension), i)}");
            }

            return Enum.GetName(typeof(EnumExtension), input.InputInt(1, Enum.GetNames(typeof(EnumExtension)).Length) - 1);
        }

        private string EnumValueWeightModificator()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Choose weightModificator. Enter integer values.");
            for (int i = 0; i < Enum.GetNames(typeof(EnumWeightModificator)).Length; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumWeightModificator), i)}");
            }

            return Enum.GetName(typeof(EnumWeightModificator), input.InputInt(1, Enum.GetNames(typeof(EnumWeightModificator)).Length) - 1);
        }

        private double EnterValue()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Enter weight. Weight must be positive. Value range is (0.001 to 1023).");
            return input.InputDouble(0.001, 1023);
        }
    }
}