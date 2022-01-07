using Xunit;

namespace testFormula
{
    public class testFormula
    {
        [Theory]
        [InlineData(1.25, 2.75, 0.3, 2.0, 0.95)]
        public void Part_A_With_D(double xn, double xk, double dx, double a, double b)
        {
            Formula10 f = new Formula10();

            double[] f_res = new double[5] { -1.134407354465639, -0.8293139784571705, -0.6369149422444634, -0.5055505458412667, -0.41063560335143323 };

            double[] res = f.calcA(xn, xk, dx, a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], f_res[i]);
            }
        }

        [Theory]
        [InlineData(2.0, 0.95)]
        public void Part_B(double a, double b)
        {
            Formula10 f = new Formula10();

            double[] x_nums = new double[5] { 2.2, 3.78, 4.51, 6.58, 1.2 };
            double[] f_res = new double[5] { -0.487649655727501, -0.1898679005946529, -0.13100454957940583, -0.048951387289583835, -1.2030664483285218 };

            double[] res = f.calcB(x_nums, a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], f_res[i]);
            }

        }
    }
}