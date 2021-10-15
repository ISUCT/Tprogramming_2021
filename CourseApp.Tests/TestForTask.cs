namespace CourseApp.Tests
{
    using Xunit;

    public class TestForTask
    {
        [Theory]
        [InlineData("VSCode", ".exe", 1.56, "GB")]
        [InlineData("ISUCT", ".HTML", 0.79, "KB")]
        [InlineData("Program", ".cs", 0.47, "B")]
        [InlineData("Music", ".mp3", 1.56, "KB")]
        [InlineData("Cat", ".exe", 1.56, "MB")]
        [InlineData("Video", ".mov", 0.63, "TB")]
        public void TestClass(string name, string extension, double weight, string weightModificator)
        {
            var expected = $"{name}{extension} {weight}{weightModificator}";
            var file = new FileCreator(name, extension, weight, weightModificator);
            var actual = file.Display();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2", 0, 3, true)]
        [InlineData("-1", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1.2", -2, -1, false)]
        [InlineData("4.1", 4, 5, false)]
        [InlineData(" ", 4, 4, false)]
        public void TestForInputInt(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var actual = input.InputInt(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2,2", 0, 3, true)]
        [InlineData("-1,5", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1", -2, -1, true)]
        [InlineData("4,1", 4, 5, true)]
        [InlineData(" ", 4, 4, false)]
        public void TestForInputDouble(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var actual = input.InputDouble(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }
    }
}
