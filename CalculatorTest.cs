namespace CourseApp.Tests
{
    using Xunit;

    public class CalculatorTest
    {
        [Theory]
        [InlineData(0.7, 0.8, 0.56)]
        [InlineData(2.2, 2.2, 4.84)]
        [InlineData(0.25, 0.2, 0.50)]
        [InlineData(0.56, 0.4, 0.229)]
        [InlineData(1.28, 0.7, 0.93)]
        public void TestCalc(int a, int b, int exp)
        {
            var calc = new Calculator();
            var res = calc.GetProduct(a, b);
            Assert.Equal(exp, res);
        }

        [Theory]
        [InlineData(10, 1, 11)]
        [InlineData(0.0f, 32.812398f, -32.812398f)]
        [InlineData(65.123, 3.002, 68.121)]
        public void TestCalc2(double a, double b, double exp)
        {
            var calc = new Calculator();

            var res = calc.GetSum(a, b);

            Assert.Equal(exp, res, 3);
        }

        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(40.123675f, 29.812398f, 72.936073f)]
        [InlineData(67.123, 3.002, 70.125)]
        public void TestCalc3(double a, double b, double exp)
        {
            var calc = new Calculator();

            var res = calc.GetQuotient(a, b);

            Assert.Equal(exp, res, 3);
        }
    }
}
