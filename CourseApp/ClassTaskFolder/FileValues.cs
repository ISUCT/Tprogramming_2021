namespace CourseApp.Class
{
    using System;
    using static System.Math;

    public class FileValues
    {
        public string FileParam(string[] stringValues)
        {
            Console.Clear();
            ConsoleOutput(stringValues);
            return stringValues[CheckIntInput(stringValues.Length) - 1];
        }

        public double Weight()
        {
            Console.Clear();
            Console.Write("Enter weight ( weight > 0 ): ");
            return InputDoubleValue();
        }

        private void ConsoleOutput(string[] str)
        {
            Console.WriteLine("Chose:");
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {str[i]}");
            }
        }

        private int InputIntValue()
        {
            var isNumber = false;
            var input = string.Empty;
            int inputValue = 0;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out inputValue);
                if (!isNumber)
                {
                    Console.WriteLine($"Value is incorrect. Please enter correct value!");
                }
            }

            return inputValue;
        }

        private double InputDoubleValue()
        {
            var isNumber = false;
            var input = string.Empty;
            double inputValue = 0;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out inputValue);
                if (!isNumber || inputValue == 0)
                {
                    Console.WriteLine($"Value is incorrect. Please enter correct value!");
                    isNumber = false;
                }
            }

            return inputValue;
        }

        private int CheckIntInput(int stringLength)
        {
            var input = 0;
            var isCorrectNumber = false;
            while (!isCorrectNumber)
            {
                input = InputIntValue();
                if (input > stringLength || input <= 0)
                {
                    Console.WriteLine("Value is out of range");
                }
                else
                {
                    isCorrectNumber = true;
                }
            }

            return input;
        }
    }
}