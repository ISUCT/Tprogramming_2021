namespace CourseApp
{
    using System;
    using CourseApp.Calculate;

    public class ConsoleInputOutput
    {
        public void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Hello!");
            Console.WriteLine("This program can calculate tasks")
            Console.WriteLine("Calculate with default values - 1 | Calculate with your values - 2");
            Console.WriteLine("What you want?");
            Calculate();
        }

        private void Calculate()
        {
            switch (IntValue())
            {
                case 1:
                {
                    Console.Clear();
                    var task = new CalculateTasks();
                    break;
                }

                case 2:
                {
                    Console.WriteLine("Enter your values:");
                    Console.Write("a = ");
                    var a = DoubleValue();
                    Console.Write("b = ");
                    var b = DoubleValue();
                    Console.Write("start = ");
                    var start = DoubleValue();
                    Console.Write("end = ");
                    var end = DoubleValue();
                    Console.Write("delta = ");
                    var delta = DoubleValue();
                    Console.Clear();
                    var task = new CalculateTasks(a, b, start, end, delta);
                    break;
                }
            }
        }

        private int IntValue()
        {
            bool isNumber = false;
            var input = string.Empty;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out int inputValue);
                if (!isNumber)
                {
                    Console.WriteLine("Please enter correct value");
                }
            }

            return Convert.ToInt32(input);
        }

        private double DoubleValue()
        {
            bool isNumber = false;
            var input = string.Empty;
            while (!isNumber)
            {
                input = Console.ReadLine();
                isNumber = double.TryParse(input, out double inputValue);
                if (!isNumber)
                {
                    Console.WriteLine("Please enter correct value");
                }
            }

            return Convert.ToDouble(input);
        }
    }
}