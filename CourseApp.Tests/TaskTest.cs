namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class TaskTest
    {
        [Theory]
        [InlineData(1, 5, 8, -2.87)]
        [InlineData(-2, 5, 1, double.NaN)]
        [InlineData(-1, -9, 1, double.NaN)]
        [InlineData(0, 0, 0, double.NaN)]
        public void TestNum(double a, double b, double x, double expected)
        {
            var func = new Functions();
            var actual = func.Numerator(a, b, x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(-2, double.NaN)]
        [InlineData(3.1, 0.33)]
        [InlineData(4, 0.109)]
        [InlineData(5, 0.218)]
        [InlineData(6.1, 0.354)]
        public void TestDenum(double x, double expected)
        {
            var func = new Functions();
            var actual = func.Denumerator(x);
            Assert.Equal(expected, actual, 3);
        }
    }
}
