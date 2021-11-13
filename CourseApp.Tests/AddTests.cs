namespace CourseApp.Tests
{
    using Xunit;

    public class AddTests
    {
        [Theory]
        [InlineData(-3, -4, -7)]
        [InlineData(-3, 2, -1)]
        [InlineData(-3, 4, 1)]
        [InlineData(4, -5, -1)]
        [InlineData(5, -4, 1)]
        [InlineData(3, 2, 5)]
        [InlineData(-3, 3, 0)]
        [InlineData(3, -3, 0)]
        [InlineData(0, 0, 0)]

        public void AddIntsInlineTheory(int a, int b, int expected)
        {
            int actual = new Calculator().Add(a, b);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AddBytesOverflow()
        {
            byte a = 255;
            byte b = 255;

            Assert.Throws<System.OverflowException>(() => new Calculator().Add(a, b));
        }
    }
}
