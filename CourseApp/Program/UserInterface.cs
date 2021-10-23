namespace CourseApp.Program
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Program.Enums;
    using CourseApp.Program.Input;

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
            Console.WriteLine(@"
In this program you can:
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
            Console.WriteLine(@"
Available actions:
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
                    Console.Clear();
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
            Console.WriteLine(@"
Available actions:
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
                    Console.Clear();
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
            Console.Clear();
            var input = new InputValues();
            CreateCustomFile(customFile);
            Console.Clear();
            Console.WriteLine(@"
Available actions:
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
            Console.Clear();
            var input = new InputValues();
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
            Console.Clear();
            var input = new InputValues();
            var enumLength = Enum.GetNames(typeof(EnumName)).Length;
            Console.WriteLine($"Choose avaible name. Enter integer values.");
            for (int i = 0; i < enumLength; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumName), i)}");
            }

            Console.WriteLine("Your variant:");
            var id = input.InputInt(1, enumLength) - 1;
            return Enum.GetName(typeof(EnumName), id);
        }

        private string EnumValueExtension()
        {
            Console.Clear();
            var input = new InputValues();
            var enumLength = Enum.GetNames(typeof(EnumExtension)).Length;
            Console.WriteLine($"Choose avaible extension. Enter integer values.");
            for (var i = 0; i < enumLength; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumExtension), i)}");
            }

            Console.WriteLine("Your variant:");
            var id = input.InputInt(1, enumLength) - 1;
            return Enum.GetName(typeof(EnumExtension), id);
        }

        private string EnumValueWeightModificator()
        {
            Console.Clear();
            var input = new InputValues();
            var enumLength = Enum.GetNames(typeof(EnumWeightModificator)).Length;
            Console.WriteLine($"Choose avaible weightModificator. Enter integer values.");
            for (var i = 0; i < enumLength; i++)
            {
                Console.WriteLine($"{i + 1} - {Enum.GetName(typeof(EnumWeightModificator), i)}");
            }

            Console.WriteLine("Your variant:");
            var id = input.InputInt(1, Enum.GetNames(typeof(EnumWeightModificator)).Length) - 1;
            return Enum.GetName(typeof(EnumWeightModificator), id);
        }

        private double EnterValue()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine(@"Enter weight. Weight must be positive. Value range is (0.001 to 1023).
Your value:");
            return input.InputDouble(0.001, 1023);
        }
    }
}