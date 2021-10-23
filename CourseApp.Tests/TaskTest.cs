namespace CourseApp.Tests
{
    using Xunit;

    public class TaskTest
    {
        [Theory]
        [InlineData(2, 1.2, 0.025)]
        [InlineData(2, 1.8, 0.023)]
        [InlineData(2, 2.4, 0.021)]
        [InlineData(2, 3, 0.02)]
        [InlineData(2, 3.6, 0.018)]
        public void TestCalculate(double a, double x, double expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Calculate(a, x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(2, 1.2, 0.255)]
        [InlineData(3, 1.8, 0.464)]
        [InlineData(4, 2.4, 0.65)]
        [InlineData(5, 3, 0.816)]
        [InlineData(6, 3.6, 0.965)]
        public void TestNumerator(double a, double x, double expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Numerator(a, x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(2, 1.2, 10.24)]
        [InlineData(3, 1.8, 23.04)]
        [InlineData(4, 2.4, 40.96)]
        [InlineData(5, 3, 64)]
        [InlineData(6, 3.6, 92.16)]
        public void TestDenumerator(double a, double x, double expected)
        {
            var calculator = new Calculator();
            var actual = calculator.Denumerator(a, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}
