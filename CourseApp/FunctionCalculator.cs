namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class FunctionCalculator
    {
        public double Calculate(double b, double x)
        {
            double top = 1 + Math.Pow(Math.Sin(Math.Pow(b, 3) + Math.Pow(x, 3)), 2);
            double bottom = Math.Pow(Math.Pow(b, 3) + Math.Pow(x, 3), 1 / 3);
            return top / bottom;
        }

        public List<double> CalculateTaskA(double xStart, double xEnd, double dX, double b)
        {
            List<double> result = new List<double>();
            for (double x = xStart; x < xEnd; x += dX)
            {
                result.Add(Calculate(b, x));
            }

            return result;
        }

        public List<double> CalculateTaskB(double[] nums, double b)
        {
            var result = new List<double>();
            foreach (double number in nums)
            {
                result.Add(Calculate(b, number));
            }

            return result;
        }
    }
}