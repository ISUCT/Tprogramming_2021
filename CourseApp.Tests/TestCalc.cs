namespace CourseApp.Tests
{
    using Xunit;

    public class DemoTest
    {
        [Fact]
        public void Test1()
        {
            var firstNumber = 2;
            var secondNumber = 3;
            var expected = 5;

            var calc = new Class1();
            var actual = calc.GetSum(firstNumber, secondNumber);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Test2()
        {
            var firstNumber = 2;
            var secondNumber = 3;
            var expected = 5;

            var calc = new Class1();
            var actual = calc.GetSum(firstNumber, secondNumber);

            Assert.Equal(actual, expected);
        }
    }
}
