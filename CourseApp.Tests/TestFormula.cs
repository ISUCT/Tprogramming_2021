using System;
using Xunit;
using Formula;

namespace TestFormula
{
    public class TestFormula
    {
        [Theory]
        [InlineData(0.2,0.95,0.15,0.05,0.06)]
        public void Part_A_With_D(double xb, double xe, double dx, double a, double b)
        {
            Formula10 f = new Formula10();

            /*double xb = 0.2;
            double xe = 0.95;
            double dx = 0.15;
            double a = 0.05;
            double b = 0.06;*/
            double[] f_res = new double[5] { 40.90742715368491, 12.067634851044216, 5.285233882132713, 2.626773674898777, 1.2744671426673164 };

            double[] res = f.PartA(xb, xe, dx, a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], f_res[i]);
            }
        }

        [Theory]
        [InlineData(0.05,0.06)]
        public void Part_B(double a, double b)
        {
            Formula10 f = new Formula10();

            /*double a = 0.05;
            double b = 0.06;*/
            double[] x_nums = new double[5] { 0.15, 0.26, 0.37, 0.48, 0.56 };
            double[] f_res = new double[5] { 77.58958649972757, 23.128832605187945, 10.660338909522668, 5.83682718123348, 3.969028946438846 };

            double[] res = f.PartB(x_nums, a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], f_res[i]);
            }

        }
    }
}
