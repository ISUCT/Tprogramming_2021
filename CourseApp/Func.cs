namespace Function
{
    using System;

    public class Func
    {
        public double MathFunction(double x)
        {
            const double a = 2.25;
            return Math.Pow(a, (x * x) - 1) - Math.Log((x * x) - 1, 10) + Math.Pow((x * x) - 1, 1 / 3);
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
