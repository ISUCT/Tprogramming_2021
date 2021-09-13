namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double y = 0;
            double x_n = 1.25;
            double x_k = 3.25;
            double x_ch = 0.4;
            double[] arr = { 1.84, 2.71, 3.81, 4.56, 5.62 };
            Console.WriteLine($"Task A");
            CalcA(y, x_n, x_k, x_ch);
            Console.WriteLine(" ");
            Console.WriteLine($"Task B");
            CalcB(y, arr);
            Console.ReadLine();
        }

        public static void CalcA(double y, double x_n, double x_k, double x_ch)
        {
            for (double x = x_n; x < x_k; x += x_ch)
            {
                Console.WriteLine($" y={Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 1 / 4.0) + Math.Pow(Math.Log(Math.Pow(x, 2)), 1 / 3.0)}");
            }
        }

        public static void CalcB(double y, double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                 Console.WriteLine($" y={Math.Pow(Math.Abs(Math.Pow(arr[i], 2) - 2.5), 1 / 4.0) + Math.Pow(Math.Log(Math.Pow(arr[i], 2)), 1 / 3.0)}");
            }
        }
    }
}