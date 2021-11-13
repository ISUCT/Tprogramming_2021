namespace CourseApp.Tests
{
    using Xunit;

    public class SubTests
    {
        [Theory]
        [InlineData(-3, -4, 1)]
        [InlineData(-3, 2, -5)]
        [InlineData(5, -4, 9)]
        [InlineData(3, 2, 1)]
        [InlineData(0, 0, 0)]
        public void SubIntsNegNegPos(int a, int b, int expected)
        {
            int actual = new Calculator().Sub(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SubBytesOverflow()
        {
            byte a = 0;
            byte b = 1;

            Assert.Throws<System.OverflowException>(() => new Calculator().Sub(a, b));
        }
    }
}
