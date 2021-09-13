namespace TestsDiv
{
    using CourseApp;
    using Xunit;

    public class Div_Neg4InPos2_returnedNeg2
    {
        [Fact]
        public void Div_NegPos_Neg()
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
