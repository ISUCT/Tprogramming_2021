namespace CourseApp
{
    using System;

    public class Function
    {
        public double MathFunction(double x = 0)
        {
            double arcSin = Math.Asin(x);
            double arcCos = Math.Acos(x);
            return Math.Pow((arcSin * arcSin * arcSin * arcSin) + (arcCos * arcCos * arcCos * arcCos * arcCos * arcCos), 1 / 7);
        }

        public double[] TaskA(double xn, double xk, double dx)
        {
            int g = (int)(((xk - xn) / dx) + 1);
            double[] results = new double[g];
            int i = 0;
            while (xn <= xk)
            {
                results[i] = MathFunction(xn);
                i++;
                xn = xn + dx;
            }

            return results;
        }

        public double[] TaskB(double[] numbers)
        {
            double[] results = new double[numbers.Length];
            int g = 0;
            foreach (double i in numbers)
            {
                results[g] = MathFunction(i);
                g++;
            }

            return results;
        }
    }
}