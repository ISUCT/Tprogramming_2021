namespace CourseApp
{
    using System;
    using static System.Math;

    public class CalculateTest
    {
        public double Calculate(double a, double x)
        {
            return Numerator(a, x) / Denumerator(a, x);
        }

        public double Numerator(double a, double x)
        {
            return Pow(Log10(a + x), 2);
        }

        public double Denumerator(double a, double x)
        {
            return Pow(a + x, 2);
        }
    }
}