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
            double y = 0;
            double xstart = 0.7;
            double xend = 2.2;
            double xdelta = 0.3;
            double[] xArr = { 0.25, 0.36, 0.56, 0.94, 1.28 };
            Console.WriteLine("Task A");
            TaskA(a, b, y, xstart, xend, xdelta);
            Console.WriteLine("Task B");
            TaskB(a, b, y, xArr);
            Console.ReadLine();
        }

        public static void TaskA(double a, double b, double y, double xstart, double xend, double xdelta)
        {
            for (double x = xstart; x < xend; x += xdelta)
            {
                y = (Pow(b, 3) + Pow(Sin(a * x), 2)) / (Acos(Pow(x, 2) * b) + Exp((-x) / 2));
                Console.WriteLine($"  y = {y}");
            }
        }

        public static void TaskB(double a, double b, double y, double[] xArr)
        {
            for (int i = 0; i < xArr.Length; i++)
            {
                y = (Pow(b, 3) + Pow(Sin(a * xArr[i]), 2)) / (Acos(Pow(xArr[i], 2) * b) + Exp((-xArr[i]) / 2));
                Console.WriteLine($"  y = {y}");
            }
        }
    }
}