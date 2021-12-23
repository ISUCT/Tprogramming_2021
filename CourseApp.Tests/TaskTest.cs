namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class TaskTest
    {
        [Theory]
        [InlineData(1, 1, 0.56, 1.393)]
        [InlineData(-1, -2, 1, 3.774)]
        [InlineData(1, 4, -1, 2.341)]
        [InlineData(0, 5, 1, 11.428)]
        public void TestNumerator(double a, double b, double x, double expected)
        {
            var tasks = new Tasks();
            var actual = tasks.Numerator(a, b, x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(1, 1.2, 56, 3.876)]
        [InlineData(5, 1.8, 0.44, 2.33)]
        [InlineData(7, 2.4, 32.4, 4.488)]
        [InlineData(4, 3, 3, 5.473)]
        [InlineData(5, 3.6, 1, 3.688)]
        public void TestDenumerator(double a, double b, double x, double expected)
        {
            var tasks = new Tasks();
            var actual = tasks.Denumerator(a, b, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}
