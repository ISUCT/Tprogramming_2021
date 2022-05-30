namespace CourseApp.Tests
{
    using CourseApp.FunctionTask;
    using Xunit;

    public class TasksTest
    {
        private Function testFunction = new Function();

        [Theory]
        [InlineData(0.08, -0.375268317244393)]
        [InlineData(0.28, -0.967708508243233)]
        [InlineData(0.48, -1.59067051384585)]
        [InlineData(0.68, -2.397641362637)]
        [InlineData(0.88, -3.68290119981102)]
        [InlineData(1.08, -8.15946237401936)]

        public void TestRunner(double x, double expectedResult)
        {
            double actualResult = testFunction.Calculate(x);

            Assert.Equal(expectedResult, actualResult, 10);
        }
    }
}
