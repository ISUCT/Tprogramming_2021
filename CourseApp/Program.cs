namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 1.2;
            double b = 0.48;
            double xstart = 0.7;
            double xend = 2.2;
            double xdelta = 0.3;
            double[] xArr = { 0.25, 0.36, 0.56, 0.94, 1.28 };
            Output(a, b, xstart, xend, xdelta, xArr);
            Console.ReadLine();
        }

        public static void Output(double a, double b, double xstart, double xend, double xdelta, double[] xArr)
        {
            Console.WriteLine("Task A");
            Console.WriteLine(TaskA(a, b, xstart, xend, xdelta));
            Console.WriteLine("Task B");
            Console.WriteLine(TaskB(a, b, xArr));
        }

        public static string TaskA(double a, double b, double xstart, double xend, double xdelta)
        {
            var str = string.Empty;
            for (double x = xstart; x <= xend; x += xdelta)
            {
                str += $"  y = {Calc(a, b, x):f3} /";
            }

            return str;
        }

        public static double Numerator(double a, double b, double x)
        {
            return Pow(b, 3) + Pow(Sin(a * x), 2);
        }

        public static double Denumerator(double a, double b, double x)
        {
            return Acos(Pow(x, 2) * b) + Exp((-x) / 2);
        }

        public static double Calc(double a, double b, double x)
        {
            return Numerator(a, b, x) / Denumerator(a, b, x);
        }

        public static string TaskB(double a, double b, double[] xArr)
        {
            var str = string.Empty;
            foreach (double item in xArr)
            {
                str += $"  y = {Calc(a, b, item):f3} /";
            }

            return str;
        }
    }
}