namespace CourseApp.Tests
{
    using Xunit;

    public class DemoTest
    {
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(2.2, 2.2, 4.4)]
        [InlineData(0.25, 0.2, 0.45)]
        [InlineData(0.56, 0.4, 0.96)]
        [InlineData(1.28, 0.7, 1.98)]
        public void TestIntSum(int firstNumber, int secondNumber, int expected)
        {
            var calc = new Calculator();
            var res = calc.GetSum(firstNumber, secondNumber);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(2, 10, 20)]
        [InlineData(0.25, 0.2, 0.05)]
        [InlineData(0.56, 0.4, 0.224)]
        [InlineData(1.28, 0.7, 0.896)]
        public void TestIntProduct(int firstNumber, int secondNumber, int expected)
        {
            var calc = new Calculator();
            var res = calc.GetProduct(firstNumber, secondNumber);
            Assert.Equal(expected, res);
        }

        [Theory]
        [InlineData(5, 2, 2.5)]
        [InlineData(4.4, 2.2, 2)]
        [InlineData(0.25, 0.2, 1.25)]
        [InlineData(10, 5, 2)]
        [InlineData(1.28, 0.8, 1.6)]
        public void TestDoubleQuotient(int firstNumber, int secondNumber, int expected)
        {
            var calc = new Calculator();
            var res = calc.GetQuotient(firstNumber, secondNumber);
            Assert.Equal(expected, res);
        }
    }
}
