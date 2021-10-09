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
            var customFile = new List<string>();
            IsFileCreated = false;
            Console.Clear();
            Console.WriteLine("In this program you can:\n1 - Create default file\n2 - Create custom file\n3 - Exit program\nWhat you want? Enter integer values.");
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
            Console.WriteLine("Available actions:\n1 - Get default file\n2 - Back to start page\n3 - Exit program\nWhat you want? Enter integer values.");
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
            Console.WriteLine("Available actions:\n1 - Get custom files\n2 - Enter custom values\n3 - Back to start page\n4 - Exit program\nWhat you want? Enter integer values.");
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
            Console.WriteLine($"Default file:\n{file.Display()}");
            Console.WriteLine("\nAvailable actions:\n1 - Back to previous page\n2 - Exit program\nWhat you want? Enter integer values.");
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
            Console.WriteLine("Available actions:\n1 - Create another custom file\n2 - Back to previous page\n3 - Exit program\nWhat you want? Enter integer values.");
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

            Console.WriteLine("\nAvailable actions:\n1 - Create custom file\n2 - Back to previous page\n3 - Exit program\nWhat you want? Enter integer values.");
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