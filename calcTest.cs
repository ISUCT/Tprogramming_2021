namespace CourseApp.Tests
{
    using Xunit;

    public class TestCalc
    {
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }

        [Fact]
        public void TestIntSum()
        {
            int firstNumber = 23;
            int secondNumber = 3;
            int expected = 6;
            var calc = new Calc();
            var actual = calc.GetSum(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleSum()
        {
            double firstNumber = 3.1;
            double secondNumber = 4.3;
            double expected = 7.4;
            var calc = new Calc();
            var actual = calc.GetSum(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIntProduct()
        {
            int firstNumber = 3;
            int secondNumber = 3;
            int expected = 9;
            var calc = new Calc();
            var actual = calc.GetProduct(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleQuotient()
        {
            double firstNumber = 7;
            double secondNumber = 2;
            double expected = 3.5;
            var calc = new Calc();
            var actual = calc.GetQuotient(firstNumber, secondNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleQuotientNull()
        {
            double firstNumber = 5;
            double secondNumber = 0;
            double expected = 2.5;
            var calc = new Calc();
            var actual = calc.GetQuotient(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }
    }
}