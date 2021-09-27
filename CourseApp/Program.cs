﻿namespace CourseApp
{
    using System;
    using CourseApp.Calculate;
    using CourseApp.Class;

    public class Program
    {
        public static void Main(string[] args)
        {
            StartProgram();
            Console.ReadLine();
        }

        public static int IntValue()
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

        public static double DoubleValue()
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

        private static void StartProgram()
        {
            Console.Clear();
            Console.WriteLine("Hello!");
            Console.WriteLine("This program can calculate tasks and create files with default or your values");
            Console.WriteLine("Calculate tasks - 1 | Create files - 2");
            Console.WriteLine("What you want?");
            switch (IntValue())
            {
                case 1:
                {
                    Calculate();
                    break;
                }

                case 2:
                {
                    WriteLine("Coming soon!")
                    break;
                }
            }
        }

        private static void Calculate()
        {
            Console.Clear();
            Console.WriteLine("Calculate tasks");
            Console.WriteLine("Calculate with default values - 1 | Calculate with your values - 2");
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
    }
}