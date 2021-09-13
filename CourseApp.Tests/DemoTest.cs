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
    }
}
