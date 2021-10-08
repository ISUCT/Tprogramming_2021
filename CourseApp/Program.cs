namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 2.0;
            var x_nach = 1.2;
            var x_kon = 4.2;
            var x_del = 0.6;
            double[] x_array = { 1.16, 1.32, 1.47, 1.65, 1.93 };
            ConsoleOut(a, x_array, x_del, x_nach, x_kon);
            Console.ReadLine();
        }

        public static double Numerator(double a, double x)
        {
            return Pow(Log10(a + x), 2);
        }

        public static double Denumerator(double a, double x)
        {
            return Pow(a + x, 2);
        }

        public static double Calculate(double a, double x)
        {
            return Numerator(a, x) / Denumerator(a, x);
        }

        public static string FillLine(double a, double x_n, double x_k, double x_ch)
        {
            var line = string.Empty;
            for (double x = x_n; x < x_k; x += x_ch)
            {
                line += $"x = {x} y = {Calculate(a, x):f3} ; ";
            }

            return line;
        }

        public static string FillLine(double a, double[] arr)
        {
            var line = string.Empty;
            foreach (double x in arr)
            {
                line += $"x = {x} y = {Calculate(a, x):f3} ; ";
            }

            return line;
        }

        public static void ConsoleOut(double a, double[] x_array, double x_del, double x_nach, double x_kon)
        {
            Console.WriteLine($"Task A");
            Console.WriteLine(FillLine(a, x_nach, x_kon, x_del));
            Console.WriteLine($"Task B");
            Console.WriteLine(FillLine(a, x_array));
        }
    }
}
