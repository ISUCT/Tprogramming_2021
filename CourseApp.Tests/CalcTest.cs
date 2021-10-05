namespace CourseApp.Tests
{
    using Xunit;

    public class CalcTest
    {
        [Fact]
        public void Multiply_100_NOERR()
        {
            var calc = new Calc();
            var a = 5;
            var b = 20;
            var exp = 100;

            var res = calc.Multiply(a, b);

            Assert.Equal(exp, res);
        }
    }
}