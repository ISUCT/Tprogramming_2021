namespace TestsDiv
{
    using CourseApp;
    using Xunit;

    public class Div4in0returnedError
    {
        [Fact]
        public void DivPosZeroErr()
        {
            double arg1 = 4;
            double arg2 = 0;
            double expected = 0;

            // act
            var actual = new Calculator().Division(arg1, arg2);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
