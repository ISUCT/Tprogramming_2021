namespace CourseApp.Tests
{
    using Xunit;

    public class Transporttest
    {
        [Fact]
        public void LenghtEqualZero()
        {
            Ship ship1 = new Ship(0, 20, 20);
            var actualResult = ship1.Length;
            Assert.Equal(0, actualResult);
        }

        [Fact]
        public void PeopleEqualZero()
        {
            Ship ship1 = new Ship(20, 20, 0);
            var actualResult = ship1.People;
            Assert.Equal(0, actualResult);
        }
    }
}