namespace CourseApp
{
    using System;
    using static System.Math;

    public class Calculator
    {
        public double Numerator(double a, double x)
        {
            return Pow(Log10(a + x), 2);
        }

        public double Denumerator(double a, double x)
        {
            return Pow(a + x, 2);
        }

        public double Calculate(double a, double x)
        {
            return Numerator(a, x) / Denumerator(a, x);
        }

        public string FillLine(double a, double xNach, double xKon, double xDel)
        {
            var line = string.Empty;
            for (double x = xNach; x < xKon; x += xDel)
            {
                line += $"x = {x:f2} y = {Calculate(a, x):f3} ; ";
            }

            return line;
        }

        public string FillLine(double a, double[] arr)
        {
            var line = string.Empty;
            foreach (double x in arr)
            {
                line += $"x = {x:f2} y = {Calculate(a, x):f3} ; ";
            }

            return line;
        }

        public void ConsoleOut(double a, double[] xArr, double xDel, double xNach, double xKon)
        {
            Console.WriteLine($"Task A: {FillLine(a, xNach, xKon, xDel)}");
            Console.WriteLine($"Task B: {FillLine(a, xArr)}");
        }
    }
}
