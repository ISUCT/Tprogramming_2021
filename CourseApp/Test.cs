namespace CourseApp
{
    using System;
    using static System.Math;

    public class Test
    {
        public double Calculate(double a, double b, double x)
        {
            return Round(Numerator(a, b, x) / Denumerator(a, b, x), 3);
        }

        public double Numerator(double a, double b, double x)
        {
            return Pow(b, 3) + Pow(Sin(a * x), 2);
        }

        public double Denumerator(double a, double b, double x)
        {
            return Acos(Pow(x, 2) * b) + Exp((-x) / 2);
        }
    }
}