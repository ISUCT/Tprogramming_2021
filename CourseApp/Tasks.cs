namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using static System.Math;

    public class Tasks
    {
        public double Numerator(double a, double b, double x)
        {
            return a + Pow(Tan(b * x), 2);
        }

        public double Denumerator(double a, double b, double x)
        {
            return b + Pow(1 / Tan(a * x), 2);
        }

        public double Calculate(double a, double b, double x)
        {
            return Numerator(a, b, x) / Denumerator(a, b, x);
        }

        public List<double> Task1(double a, double b, double start, double end, double delta)
        {
            var lst = new List<double>();
            for (double x = start; x < end; x += delta)
            {
                lst.Add(Calculate(a, b, x));
            }

            return lst;
        }

        public List<double> Task2(double a, double b, double[] xArray)
        {
            var lst = new List<double>();
            foreach (double x in xArray)
            {
                lst.Add(Calculate(a, b, x));
            }

            return lst;
        }
    }
}
