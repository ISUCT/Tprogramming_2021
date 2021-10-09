namespace CourseApp
{
    using System;
    using CourseApp.Class;

    public class ConsoleInputOutput
    {
        public void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Hello!\nThis program can create files with default or your params\nFile with default params - 1 | File with your params - 2\nWhat you want?");
            Class();
        }

        private void Class()
        {
            string[] name = { "isuct", "Funny", "Test", "Car", "Page", "IDE", "Game", "Video", "Music", "Work" };
            string[] extension = { ".txt", ".pdf", ".jpg", ".cs", ".html", ".png", ".abb", ".mp3", ".mp4" };
            string[] weightModificator = { "B", "KB", "MB", "GB", "TB", "PB" };
            switch (IntValue())
            {
                case 1:
                {
                    Console.Clear();
                    var task = new ClassTask();
                    task.GetDefaultFile();
                    break;
                }

                case 2:
                {
                    Console.Clear();
                    var value = new FileValues();
                    var task = new ClassTask();
                    task.GetCreatedFile(value.FileParam(name), value.FileParam(extension), value.Weight(), value.FileParam(weightModificator));
                    break;
                }
            }
        }

        private int IntValue()
        {
            bool isNumber = false;
            var input = string.Empty;
            int inputValue = 0;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out inputValue);
                if (!isNumber || inputValue <= 0 || inputValue > 2)
                {
                    Console.WriteLine("Value is out of range. Please enter correct value!");
                    isNumber = false;
                }
            }

            return inputValue;
        }

        private double DoubleValue()
        {
            bool isNumber = false;
            var input = string.Empty;
            double inputValue = 0;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out inputValue);
                if (!isNumber || inputValue == 0)
                {
                    Console.WriteLine("Value is out of range. Please enter correct value!");
                    isNumber = false;
                }
            }

            return inputValue;
        }
    }
}