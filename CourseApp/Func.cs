using System;


namespace Function
{
    using System;

    public class Func
    {
        public double MathFunction(double x)
        {
            const double a = 2.0;
            const double b = 3.0;

            return Math.Asin(Math.Pow(x, a)+ Math.Acos(Math.Pow(x, b)));
        }

        public double[] TaskA(double xn, double xk, double dx)
        {
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