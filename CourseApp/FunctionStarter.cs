namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public class FunctionStarter
    {
        public static void Start(string[] args)
        {
            var runner = new TaskRunner();
            var a = 1.6;
            var xn = 1.2;
            var xk = 3.7;
            var dx = 0.5;
            Console.WriteLine(Colors.FgCyan("-----TASK A-----").BgBlack());
            var listA = runner.Calculation(a, xn, xk, dx);
            ConsoleOutput(listA);
            Console.WriteLine(Colors.FgCyan("-----TASK B-----").BgBlack());
            var xs = new List<double>() { 1.28, 1.36, 2.47, 3.68, 4.56 };
            var listB = runner.Calculation(a, xs);
            ConsoleOutput(listB);
        }

        private static void ConsoleOutput(List<double> ys)
        {
            foreach (var y in ys)
            {
                Console.WriteLine(Colors.FgCyan($"y = {y}").BgBlack());
            }
        }
    }
}