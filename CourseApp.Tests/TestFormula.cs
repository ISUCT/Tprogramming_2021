using System;
using Xunit;
using Formula;

namespace TestFormula
{
    public class TestFormula
    {
        [Theory]
        [InlineData(1.2,5.2,0.8,4.1,2.7)]
        public void TestFormulaA(double xb, double xe, double dx, double a, double b)
        {
            Formula13 f = new Formula13();

            double[] f_res = new double[5] { -5.988041709469331, 1, 20.10917011949253, 13.56786626062469, 11.505040323579745 };

            double[] res = f.countFormulaA(xb, xe, dx, a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], f_res[i]);
            }
        }

        [Theory]
        [InlineData(4.1,2.7)]
        public void TestFormulaB(double a, double b)
        {
            Formula13 f = new Formula13();

            double[] x_nums = new double[5] { 1.9, 2.15, 2.34, 2.73, 3.16 };
            double[] f_res = new double[5] { -99.97670497061331, 77.88791023801342, 38.122692372591594, 21.380274597107814, 16.020495497448806 };

            double[] res = f.countFormulaB(x_nums, a, b);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], f_res[i]);
            }
        }
    }
}
