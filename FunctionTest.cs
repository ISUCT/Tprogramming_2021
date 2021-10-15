namespace CourseApp.Tests
{
    using Xunit;

    public class FunctionTest
    {
        [Fact]
        public void FirstTest()
        {
            var calc = new Function();
            double a = 7.2;
            double b = 4.2;
            double x = 3.9;
            var exp = 6.66759;

            var res = calc.Calculate(a, b, x);

            Assert.Equal(exp, res, 4);
        }

        [Fact]
        public void SecondTest()
        {
            var calc = new Function();
            double a = 7.2;
            double b = 4.2;
            double x = 1.714285;
            var exp = 0;

            var res = calc.FunctionTest(a, b, x);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void ThirdTest()
        {
            var calc = new Function();
            double a = 0;
            double b = 4.2;
            double x = 3.9;
            var exp = 8.90645;

            var res = calc.FunctionTest(a, b, x);

            Assert.Equal(exp, res);
        }

        [Fact]
        public void FourthTest()
        {
            var calc = new Function();
            double a = 7.2;
            double b = 0;
            double x = 3.9;
            var exp = 5.90492;

            var res = calc.FunctionTest(a, b, x);

            Assert.Equal(exp, res);
        }
    }
}
