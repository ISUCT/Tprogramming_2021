namespace CourseApp
{
    using System;
    using static System.Math;

    public class Program
    {
        public static void Main(string[] args)
        {
            var xn = 1.25;
            var xk = 3.25;
            var xch = 0.4;
            double[] arr = { 1.84, 2.71, 3.81, 4.56, 5.62 };
            ConsoleOut(arr, xch, xn, xk);
            var ship1 = new Ship(20, 200, 10);
            ship1.GetInfo();
            var ship2 = new Ship(10, 100, 5);
            ship2.GetLength();
            var ship3 = new Ship();
            var auto1 = new Auto(3, 150, 5);
            auto1.GetInfo();
            var auto2 = new Auto(3, 100, 5);
            auto2.GetLength();
            Console.ReadLine();
        }

        public static double Calculate(double x)
        {
            return Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 1 / 4.0) + Math.Pow(Math.Log(Math.Pow(x, 2)), 1 / 3.0);
        }

        public static string CalcA(double xn, double xk, double xch)
        {
            var strg = string.Empty;
            for (double x = xn; x < xk; x += xch)
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

        public static void ConsoleOut(double[] arr, double xch, double xn, double xk)
        {
            Console.WriteLine($"Task A");
            Console.WriteLine(CalcA(xn, xk, xch));
            Console.WriteLine($"Task B");
            Console.WriteLine(CalcB(arr));
        }
    }
}