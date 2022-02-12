namespace CourseApp.Tests
{
    using Xunit;

    public class DemoTest
    {
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestIntSum()
        {
            int firstNumber = 2;
            int secondNumber = 3;
            int expected = 5;
            var calc = new Calculator();
            var actual = calc.GetSum(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIntProduct()
        {
            int firstNumber = 2;
            int secondNumber = 3;
            int expected = 6;
            var calc = new Calculator();
            var actual = calc.GetProduct(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleQuotient()
        {
            double firstNumber = 5;
            double secondNumber = 2;
            double expected = 2.5;
            var calc = new Calculator();
            var actual = calc.GetQuotient(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleQuotientNull()
        {
            var calc = new Calculator();
            double firstNumber = 5;
            double secondNumber = 0;
            double expected = double.PositiveInfinity;

            var actual = calc.GetQuotient(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }
    }
}