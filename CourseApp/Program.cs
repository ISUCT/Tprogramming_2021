namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 4.1;
            var b = 2.7;
            var xn = 1.5;
            var xk = 3.5;
            var xd = 0.4;
            double[] array = { 2.4, 2.15, 2.34, 2.74, 3.16 };
            var func = new Functions();
            func.Lab1Run(a, b, xd, xn, xk);
            func.Lab2Run(a, b, array);
            Console.ReadLine();
        }
    }
}
