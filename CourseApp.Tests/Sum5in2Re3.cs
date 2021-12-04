namespace TestsSum
{
    using CourseApp;
    using Xunit;

    public class Sum_5in2_Re3
    {
        [Fact]
        public void AddDoublesPosNegPos()
        {
            double a = 5;
            double b = -2;
            double expected = 3;
            var actual = new Calculator().Sum(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
