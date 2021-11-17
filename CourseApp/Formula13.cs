using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula
{
    public class Formula13
    {
        public double countFormula(double a, double x, double b)
        {
            double numerator = a * Math.Sqrt(x) - b * Math.Log(x, 5);
            double denumerator = Math.Log10(Math.Abs(x - 1));
            if (double.IsInfinity(numerator/denumerator))
            {
                return 1;
            }
            return numerator / denumerator;
        }

        public double[] countFormulaA(double xb, double xe, double dx, double a, double b)
        {
            int len = (int)((xe - xb) / dx);
            double[] res = new double[len];
            int i = 0;
            while (xb < xe)
            {
                res[i] = countFormula(a, xb, b);
                i++;
                xb = Math.Round(xb+dx, 2);
            }

            return res;
        }

        public double[] countFormulaB(double[] x, double a, double b)
        {
            double[] res = new double[x.Length];

            for (int i = 0; i < res.Length; i++)
            {
                res[i] = countFormula(a, x[i], b);
            }

            return res;
        }
    }
}
