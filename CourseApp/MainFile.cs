namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class MainFile
    {
        public static void Main(string[] args)
        {
            var a = 0.1;
            var b = 0.5;
            var start = 0.15;
            var end = 1.37;
            var delta = 0.25;
            double[] xArray = { 0.2, 0.3, 0.44, 0.6, 0.56 };
            var tasks = new Tasks();
            Console.WriteLine($"One");
            Print(tasks.Task1(a, b, start, end, delta));
            Console.WriteLine($"Two");
            Print(tasks.Task2(a, b, xArray));
            Console.ReadLine();
        }

        public static void Print(List<double> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine($"y = {value:f5}");
            }
        }
    }
}
