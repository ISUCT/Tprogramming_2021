namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            var x_n = 1.25;
            var x_k = 3.25;
            var x_ch = 0.4;
            double[] arr = { 1.84, 2.71, 3.81, 4.56, 5.62 };
            ConsoleOut(arr, x_ch, x_n, x_k);
            Console.ReadLine();
        }

        public static double Calculate(double x)
        {
            return Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 1 / 4.0) + Math.Pow(Math.Log(Math.Pow(x, 2)), 1 / 3.0);
        }

        public static string CalcA(double x_n, double x_k, double x_ch)
        {
            var strg = string.Empty;
            for (double x = x_n; x < x_k; x += x_ch)
            {
                strg += $" y = {Calculate(x):f3} | ";
            }

            return strg;
        }

        public static string CalcB(double[] arr)
        {
            var strg = string.Empty;
            foreach (double x in arr)
            {
                strg += $" y = {Calculate(x):f3} | ";
            }

            return strg;
        }

        public static void ConsoleOut(double[] arr, double x_ch, double x_n, double x_k)
        {
            Console.WriteLine($"Task A");
            Console.WriteLine(CalcA(x_n, x_k, x_ch));
            Console.WriteLine($"Task B");
            Console.WriteLine(CalcB(arr));
        }
    }
}