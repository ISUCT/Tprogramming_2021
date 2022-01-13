namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            TaskTwo a = new TaskTwo();
            a.InitData("13.01.2022");
            Console.WriteLine(a.Check());
            a.InitData("02.03.1554");
            Console.WriteLine(a.Check());
            double x_s = 1.25;
            double x_f = 2.75;
            double dx = 0.3;
            double[] ans_a = new double[(int)((x_f - x_s) / dx) + 1];
            TaskA(ref ans_a, x_s, x_f, dx);
            double[] arg = { 2.2, 3.78, 4.51, 6.58, 1.2 };
            double[] ans_b = new double[5];
            TaskB(ref ans_b, arg);
            Console.WriteLine("Task A:");
            ShowUp(ans_a);
            Console.WriteLine("Task B:");
            ShowUp(ans_b);
            Console.ReadLine();
        }

        public static double Foo(double x)
        {
            if (x <= 0)
            {
                return -1;
            }

            double y;
            const double a = 2.0;
            const double b = 0.95;
            y = (1 + Math.Pow(Math.Log(x / a, 10), 2)) / (b - Math.Pow(Math.E, x / a));
            return y;
        }

        private static void ShowUp(double[] m)
        {
            for (int i = 0; i < m.Length - 1; i++)
            {
                Console.Write($"{m[i]}, ");
            }

            Console.WriteLine(m[m.Length - 1]);
        }

        private static void TaskA(ref double[] m, double x_s, double x_f, double dx)
        {
            int i = 0;
            for (double x = x_s; x <= x_f; x += dx)
            {
                m[i] = Foo(x);
                i++;
            }
        }

        private static void TaskB(ref double[] ans, double[] m)
        {
            for (int i = 0; i < m.Length; i++)
            {
                ans[i] = Foo(m[i]);
            }
        }
    }
}
