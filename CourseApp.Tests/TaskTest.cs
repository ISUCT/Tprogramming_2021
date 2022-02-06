namespace CourseApp.Tests
{
    using Xunit;

    public class TaskTest
    {
        [Theory]
        [InlineData(1.25, 1.748)]
        [InlineData(3.25, 3.016)]
        [InlineData(1.84, 2.038)]
        [InlineData(3.81, 3.25)]
        [InlineData(5.62, 3.834)]
        public void TestCalc(double x, double expected)
        {
            var actual = new CalcTest().Calculate(x);
            Assert.Equal(expected, actual, 3);
        }
    }
}