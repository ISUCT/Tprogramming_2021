namespace TestsDiv
{
    using CourseApp;
    using Xunit;

    public class Div_4in0_returnedError
    {
        [Fact]
        public void Div_PosZero_Err()
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
