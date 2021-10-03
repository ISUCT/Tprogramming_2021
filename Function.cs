namespace CourseApp
{
    using System;

    public class Function
    {
        public void Calculate(double a, double b, double x)
        {
            double top = Math.Sqrt(Math.Abs(a - (b * x)));
            double bottom = Math.Sqrt(Math.Pow(Math.Log(10), 3));
            double y = top / bottom;
            Console.WriteLine(Math.Round(y, 3));
        }

        public void CalculateTaskA(double xStart, double xEnd, double dX, double a, double b)
        {
            for (double x = xStart; x < xEnd; x += dX)
            {
                Calculate(a, b, x);
            }
        }

        public void CalculateTaskB(double[] nums, double a, double b)
        {
            foreach (double number in nums)
            {
                Calculate(a, b, number);
            }
        }
    }
}
