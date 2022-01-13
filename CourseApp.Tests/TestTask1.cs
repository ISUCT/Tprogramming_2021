namespace CourseApp.Tests
{
    using Xunit;

    public class TestTask1
    {
        private readonly Func _func;

        public TestTask1()
        {
            _func = new Func();
        }

        [Theory]
        [InlineData(1.4, )]
        [InlineData(0, -1)]
        [InlineData(-2.1, -1)]
        [InlineData()]
        public void RunTest(double x, double expected)
        {
            double ans = _func.Foo(x);
            Assert.Equal(expected, ans, 3);
        }
    }
}
