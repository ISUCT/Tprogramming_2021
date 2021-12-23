namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

    public class Functions
    {
        public double Numerator(double a, double b, double x)
        {
            return (a * Pow(x, 1 / 3)) - (b * Log(5, x));
        }

        public double Denumerator(double x)
        {
            return Pow(Log10(x - 1), 3);
        }

        public List<double> CalculateA(double a, double b, double xn, double xk, double xd)
        {
            var calc = new List<double>();
            for (double x = xn; x <= xk; x += xd)
            {
                calc.Add(Numerator(a, b, x) / Denumerator(x));
            }

            return calc;
        }

        public List<double> CalculateB(double a, double b, double[] array)
        {
            var calc = new List<double>();
            foreach (double x in array)
            {
                calc.Add(Numerator(a, b, x) / Denumerator(x));
            }

            return calc;
        }

        public void Lab1Run(double a, double b, double xd, double xn, double xk)
        {
            var labA = CalculateA(a, b, xn, xk, xd);
            Console.WriteLine($"Task A");
            for (var i = 0; i < labA.Count; i++)
            {
                Console.WriteLine($"y = {labA[i]}");
            }
        }

        public void Lab2Run(double a, double b, double[] array)
        {
            var labB = CalculateB(a, b, array);
            Console.WriteLine($"Task B");
            for (var i = 0; i < labB.Count; i++)
            {
                Console.WriteLine($"y = {labB[i]}");
            }
        }
    }
}
