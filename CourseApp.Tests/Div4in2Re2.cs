namespace TestsDiv
{
    using CourseApp;
    using Xunit;

    public class Div_4in2_Re2
    {
        [Fact]
        public void Div4Div2Returned2()
        {
            double arg1 = 4;
            double arg2 = 2;
            double expected = 2;

            // act
            var actual = new Calculator().Division(arg1, arg2);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivNegPosNeg()
        {
            double arg1 = -4;
            double arg2 = 2;
            double expected = -2;

            // act
            var actual = new Calculator().Division(arg1, arg2);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
