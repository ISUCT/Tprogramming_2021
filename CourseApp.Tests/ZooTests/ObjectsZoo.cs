namespace CourseApp.Tests.ZooTests
{
    using CourseApp.Zoo.Objects;
    using Xunit;

    public class ObjectsZoo
    {
        private Buildings _buildings;
        private InteriorStaff _interiorStaff;

        [Theory]
        [InlineData("Paddok", "For Something", "Building Paddok For Something is situated at Zoo")]
        [InlineData("Administration", "For Something", "Building Administration For Something is situated at Zoo")]
        public void TestBuilding(string name, string type, string expected)
        {
            _buildings = new Buildings(name, type);
            Assert.Equal(expected, _buildings.Draw());
        }

        [Theory]
        [InlineData("Road", "For Something", "Object Road For Something is situated at Zoo")]
        [InlineData("Lamp", "For Something", "Object Lamp For Something is situated at Zoo")]
        public void TestInteriorObject(string name, string type, string expected)
        {
            _interiorStaff = new InteriorStaff(name, type);
            Assert.Equal(expected, _interiorStaff.Draw());
        }
    }
}