namespace CourseApp
{
    using System;
    using static System.Math;

    public class CalcTest
    {
        public double Calculate(double x)
        {
            return Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 1 / 4.0) + Math.Pow(Math.Log(Math.Pow(x, 2)), 1 / 3.0);
        }
    }
}