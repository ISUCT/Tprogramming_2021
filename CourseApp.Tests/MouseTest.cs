namespace CourseApp.Tests
{
    using Xunit;

    public class MouseTest
    {
        [Fact]
        public void MouseAge_12_ERR()
        {
            Mouse test_mouse = new Mouse();
            int test_age = 12;

            test_mouse.Age = test_age;

            Assert.Equal(test_age, test_mouse.Age);
        }

        [Fact]
        public void MouseAge_2_NOERR()
        {
            Mouse test_mouse = new Mouse();
            int test_age = 2;

            test_mouse.Age = test_age;

            Assert.Equal(test_age, test_mouse.Age);
        }
    }
}