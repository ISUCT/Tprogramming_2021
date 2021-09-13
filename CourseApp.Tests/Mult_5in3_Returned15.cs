namespace TestsMult
{
    using CourseApp;
    using Xunit;

    public class Mult_5in3_Returned15
    {
        [Fact]
        public void Mult_PosPosPos()
        {
            double a = 5;
            double b = 3;
            double expected = 15;
            var actual = new Calculator().Multiplying(a, b);

            Assert.Equal(expected, actual);
        }
    }
}
