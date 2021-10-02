namespace CourseApp.Tests
{
    using CourseApp.Calculate;
    using Xunit;
    using static System.Math;

    public class TestForTasks
    {
        [Theory]
        [InlineData(3, 2, 0.11, 1.56)]
        [InlineData(3, 2, 0.36, 1.488)]
        [InlineData(3, 2, 0.08, 1.565)]
        [InlineData(3, 2, 0.026, 1.57)]
        [InlineData(3, 2, 0.35, 1.491)]
        [InlineData(3, 2, 0.41, 1.471)]
        [InlineData(3, 2, 0.51, 1.441)]
        public void TestCalculate(double a, double b, double x, double expected)
        {
            var calculateTask = new CalculateTasks();
            var actual = calculateTask.CalculateValue(a, b, x);
            Assert.Equal(expected, actual, 3);
        }
    }
}
