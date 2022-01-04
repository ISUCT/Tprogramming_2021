namespace CourseApp.Tests {
    using Xunit;

    public class Tests {
        private Function glavFunc;

        public Tests() {
            glavFunc = new Function();
        }

        [Theory]
        [InlineData(1.23, 1.617)]
        [InlineData(6.03, 2.996)]
        [InlineData(3.84, 2.549)]
        [InlineData(-6.21, 3.39)]
        public void RunTest(double x, double expa) {
            var a = 0.8;
            var b = 0.4;
            var now = glavFunc.CalculateFunction(a, b, x);
            Assert.Equal(expa, now, 3);
        }
    }
} 