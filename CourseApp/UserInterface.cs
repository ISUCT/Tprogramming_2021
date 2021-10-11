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
            var file = new FileCreator("Program", ".cs", 0.34, "MB");
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Default file:\r\n{file.Display()}");
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
            string[] fileName = { "isuct", "Funny", "Test", "Car", "Page", "IDE", "Game", "Video", "Music", "Work" };
            string[] extension = { ".txt", ".pdf", ".jpg", ".cs", ".html", ".png", ".abb", ".mp3", ".mp4" };
            string[] weightModificator = { "B", "KB", "MB", "GB", "TB", "PB" };
            var input = new InputValues();
            var file = new FileCreator(EnterValue(fileName), EnterValue(extension), EnterValue(), EnterValue(weightModificator));
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
                Console.WriteLine("Your files:");
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

        private string EnterValue(string[] arr)
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Choose value. Enter integer values.");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {arr[i]}");
            }

            return arr[input.InputInt(1, arr.Length)];
        }

        private double EnterValue()
        {
            var input = new InputValues();
            Console.Clear();
            Console.WriteLine($"Enter value. Weight must be positive. Value range is (0.001 to 1023).");
            return input.InputDouble(0.001, 1023);
        }
    }
}