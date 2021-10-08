namespace CourseApp.Tests
{
    using Xunit;

    public class TaskTest
    {
        [Theory]
        [InlineData(0.7, 0.326)]
        [InlineData(2.2, double.NaN)]
        [InlineData(0.25, 0.082)]
        [InlineData(0.56, 0.229)]
        [InlineData(1.28, 0.93)]
        public void TestCalc(double x, double expected)
        {
            var a = 1.2;
            var b = 0.48;
            var actual = new Test().Calculate(a, b, x);
            Assert.Equal(expected, actual);
        }
    }
}
