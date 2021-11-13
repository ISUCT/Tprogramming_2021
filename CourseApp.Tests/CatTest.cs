namespace CourseApp.Tests
{
    using Xunit;

    public class CatTest
    {
        [Fact]
        public void NegativeAge()
        {
            Assert.Throws<System.ArgumentException>(() => new Cat(-2, "TestName", 10));
        }

        [Fact]
        public void NegativeTail()
        {
            Assert.Throws<System.ArgumentException>(() => new Cat(0, "TestName", -2));
        }

        [Fact]
        public void EmptyName()
        {
            Assert.Throws<System.ArgumentException>(() => new Cat(1, string.Empty, 10));
        }
    }
}
