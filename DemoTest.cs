namespace CourseApp.Tests
{
    using Xunit;

    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var firstNumber = 23;
            var secondNumber = 3;
            var expected = 26;

            // Actual
            var actual = new Class1().GetSum(firstNumber, secondNumber);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var firstNumber = 23;
            var secondNumber = 3;
            var expected = 26;

            // Actual
            var actual = new Class1().GetSum(firstNumber, secondNumber);

            // Assert
            Assert.Equal(actual, expected);
        }
    }
}





/*
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
            var actual = calc.GetIntSum(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleSum()
        {
            double firstNumber = 2.1;
            double secondNumber = 3.3;
            double expected = 5.4;
            var calc = new Calculator();
            var actual = calc.GetDoubleSum(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIntProduct()
        {
            int firstNumber = 2;
            int secondNumber = 3;
            int expected = 6;
            var calc = new Calculator();
            var actual = calc.GetIntProduct(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleQuotient()
        {
            double firstNumber = 5;
            double secondNumber = 2;
            double expected = 2.5;
            var calc = new Calculator();
            var actual = calc.GetDoubleQuotient(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDoubleQuotientNull()
        {
            double firstNumber = 5;
            double secondNumber = 0;
            double expected = 2.5;
            var calc = new Calculator();
            var actual = calc.GetDoubleQuotient(firstNumber, secondNumber);

            Assert.Equal(expected, actual);
        }
    }
}
*/