namespace CourseApp.Tests
{
    using Xunit;

    public class ShipTests
    {
        [Fact]
        public void DisplacementEqualZero()
        {
            Ship ship1 = new Ship(20, 0, 20);
            var actualResult = ship1.Displacement;
            Assert.Equal(0, actualResult);
        }
    }
}