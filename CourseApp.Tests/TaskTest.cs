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
        public void TestCalc(double a, double x, double expected)
        {
            var actual = new CalculateTest().Calculate(a, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}
