using System;

namespace Formula
{
    public class Formula10
    {
        public double Form10(double x, double a, double b)
        {
            double numerator = Math.Acos((x * x) - (b * b));
            double denumerator = Math.Asin((x * x) - (a * a));
            return numerator / denumerator;
        }

        public double[] PartA(double xb, double xe, double dx, double a, double b)
        {
            int len = (int)((xe - xb) / dx);
            double[] res = new double[len];
            int i = 0;
            while(xb <= xe)
            {
                res[i] = Form10(xb, a, b);
                i++;
                xb += dx;
            }

            return res;
        }

        public double[] PartB(double[] x, double a, double b)
        {
            int len = 5;
            double[] res = new double[len];

            for(int i=0; i<res.Length; i++)
            {
                res[i] = Form10(x[i], a, b);
            }

            return res;
        }
    }
}
