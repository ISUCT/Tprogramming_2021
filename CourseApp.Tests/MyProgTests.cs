namespace CourseApp.Tests
{
    using Xunit;

    public class MyProgTests
    {
    [Fact]
    public void Sum1_And2_Returned3()
        {
            int x = 1;
            int y = 2;
            int expected = 3;

            MyProg c = new MyProg();
            int actual = c.Sum(x, y);

            Assert.Equal(expected, actual);
        }
    }
}
