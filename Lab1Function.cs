namespace CourseApp
{
    using System;

    public class Lab1Function
    {
        public void Calculate(double b, double x, double a)
        {
            double top = Math.Pow(b, 3) + Math.Pow(Math.Sin(a * x), 2);
            double bottom = Math.Acos(x * b * x) + Math.Exp(-x / 2);
            double y = top / bottom;
            Console.WriteLine(y);
        }

        public void CalculateTaskA(double xStart, double xEnd, double dX, double b, double a)
        {
            for (double x = xStart; x < xEnd; x += dX)
            {
                Calculate(b, x, a);
            }
        }

        public void CalculateTaskB(double[] nums, double b, double a)
        {
            foreach (double number in nums)
            {
                Calculate(b, number, a);
            }
        }
    }
}
