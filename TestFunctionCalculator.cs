namespace CourseApp.Tests
{
    using Xunit;

    public class TestFunctionCalculator
    {
        [Fact]
        public void TestRight()
        {
            var calc = new FunctionCalculator();

            double firstNumber = 2;
            double secondNumber = 6;
            double thirdNumber = 7;
            double expected = 1.7;

            double actual = calc.Calculate(firstNumber, secondNumber, thirdNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestQuotientNull()
        /*знаменатель больше нуля(на ноль делить нельзя)*/
        {
            var calc = new FunctionCalculator();

            double firstNumber = 0;
            double secondNumber = 5;
            double thirdNumber = 0;
            double expected = double.PositiveInfinity;

            double actual = calc.Calculate(firstNumber, secondNumber, thirdNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPositiveBase()
        /*основание логарифма (а) должно быть больше нуля*/
        {
            var calc = new FunctionCalculator();

            double firstNumber = -1;
            double secondNumber = 5;
            double thirdNumber = 7;
            double expected = double.PositiveInfinity;

            double actual = calc.Calculate(firstNumber, secondNumber, thirdNumber);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAMoreOne()
        /*основание логарифма (а) не должно равняться 1 по определению*/
        {
            var calc = new FunctionCalculator();

            double firstNumber = 1;
            double secondNumber = 5;
            double thirdNumber = 7;
            double expected = double.PositiveInfinity;

            double actual = calc.Calculate(firstNumber, secondNumber, thirdNumber);
            Assert.Equal(expected, actual);
        }
    }
}