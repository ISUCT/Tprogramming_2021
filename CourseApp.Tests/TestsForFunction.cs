namespace CourseApp.Tests
{
    using Xunit;

    public class TestsForFunction
    {
        private readonly Function _function;

        public TestsForFunction()
        {
            _function = new Function();
        }

        [Theory]
        [InlineData(1.2, 0.8256)]
        [InlineData(1.7, 0.9182)]
        [InlineData(2.2, 3.9286)]
        [InlineData(3.7, 385.8624)]
        public void RunTest(double x, double expected)
        {
            var a = 1.6;
            var actual = _function.CalculateFunction(a, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}