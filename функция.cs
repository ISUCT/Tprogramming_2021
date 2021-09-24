namespace CourseApp
{
    using System;

    public class Функция
    {
        public void Calculate(double a, double b, double x)
        {
            double top = Math.Sqrt(Math.Abs(a - (b * x)));
            double bottom = Math.Sqrt(Math.Pow(Math.Log(10), 3));
            double y = Math.Round(top / bottom, 3);
            Console.WriteLine(y);
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
