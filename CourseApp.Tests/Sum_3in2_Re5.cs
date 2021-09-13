namespace TestsSum
{
    using CourseApp;
    using Xunit;

    public class Sum_3in2_Re5
    {
        [Fact]
        public void AddDoublesPosPosPos()
        {
            double a = 3;
            double b = 2;
            double expected = 5;
            var actual = new Calculator().Sum(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
