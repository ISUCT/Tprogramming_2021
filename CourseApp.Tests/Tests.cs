namespace CourseApp.Tests
{
    using Xunit;

    public class Tests
    {
        private Function _mainFunc;

        public Tests()
        {
            _mainFunc = new Function();
        }

        [Theory]
        [InlineData(1.81, 4.84)]
        [InlineData(6.17, 1.86)]
        [InlineData(3.9, 1.3952)]
        [InlineData(3.16, 1.795)]
        public void RunTest(double x, double expected)
        {
            var a = 7.2;
            var b = 4.2;
            var actual = _mainFunc.CalculateFunction(a, b, x);
            Assert.Equal(expected, actual, 3);
        }
    }
} 