namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            double xs = 0.26;
            double xe = 0.66;
            double dx = 0.08;
            double[] some_array1 = MathFunc1(xs, xe, dx);
            Console.WriteLine("Выполнение задачи A:");
            for (int i = 0; i < ((xe - xs) / dx) + 1; i++)
            {
                Console.WriteLine(some_array1[i]);
            }

            double[] x = { 0.1, 0.35, 0.4, 0.55, 0.6 };
            double[] some_array2 = MathFunc2(x);
            Console.WriteLine("Выполнение задачи B:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(some_array2[i]);
            }
        }

        public static double[] MathFunc1(double xs, double xe, double dx)
        {
            double length_of_massiv = ((xe - xs) / dx) + 1;
            int lom = (int)length_of_massiv;
            double[] massiv = new double[lom];
            int k = 0;
            for (double i = xs; i <= xe; i += dx)
            {
                massiv[k] = Math.Pow(Math.Pow(Math.Asin(i), 2.0) + Math.Pow(Math.Acos(i), 4.0), 3.0);
                k++;
            }

            return massiv;
        }

        public static double[] MathFunc2(double[] x)
        {
            double[] massiv = new double[5];
            for (int i = 0; i < 5; i++)
            {
                massiv[i] = Math.Pow(Math.Pow(Math.Asin(x[i]), 2.0) + Math.Pow(Math.Acos(x[i]), 4.0), 3.0);
            }

            return massiv;
        }
    }
}
