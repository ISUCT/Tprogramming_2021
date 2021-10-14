namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class FunctionCalculator
    {
        public double Calculate(double a, double b, double x)
        {
            double top = Math.Log(Math.Abs(Math.Pow(b, 2) - Math.Pow(x, 2)), a);
            double bottom = Math.Pow(Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2)), 1 / 5);
            double y = top / bottom;
            return y;
        }

        public List<double> CalculateTaskA(double a, double xStart, double xEnd, double dX, double b)
        {
            List<double> result = new List<double>();
            for (double x = xStart; x < xEnd; x += dX)
            {
                result.Add(Calculate(a, b, x));
            }

            return result;
        }

        public List<double> CalculateTaskB(double a, double[] nums, double b)
        {
            List<double> result = new List<double>();
            foreach (double number in nums)
            {
                result.Add(Calculate(a, b, number));
            }

            return result;
        }
    }
}