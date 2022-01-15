namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Function
    {
        public double CalculateFunction(double a, double b, double x)
        {
            return Math.Round(Math.Pow(Math.Abs(a - (b * x)) / Math.Pow(Math.Log(x, 10), 3), 1.0 / 2.0));
        }
    }
}