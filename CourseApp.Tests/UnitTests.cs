namespace CourseApp.Tests
{
    using Xunit;

    public class UnitTests
    {
        [Theory]
        [InlineData("VSCode", "Exe", 1.56, "GB")]
        [InlineData("ISUCT", "HTML", 0.79, "KB")]
        [InlineData("Program", "Cs", 0.47, "B")]
        [InlineData("Music", "Mp3", 1.56, "KB")]
        [InlineData("Cat", "Exe", 1.56, "MB")]
        [InlineData("Video", "Mov", 0.63, "TB")]
        public void TestClass(string name, string extension, double weight, string weightModificator)
        {
            var expected = $"{name}.{extension} {weight}{weightModificator}";
            var file = new FileCreator(name, extension, weight, weightModificator);
            var actual = file.Display();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, -1, 2, true)]
        [InlineData(0, 1, 2, false)]
        [InlineData(1, 0, 2, true)]
        [InlineData(1, 1, 2, true)]
        [InlineData(-1, 0, 1, false)]
        [InlineData(-1, -1, -1, true)]
        [InlineData(2, 2, 4, true)]
        [InlineData(-2, -1, 2, false)]
        [InlineData(3, 2, 3, true)]
        [InlineData(-3, -5, 0, true)]
        public void TestCheckValuesInputInt(int input, int min, int max, bool expected)
        {
            var check = new CheckValues();
            var actual = check.IsValidInt(input, min, max);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0.1, -1, 2, true)]
        [InlineData(0.5, 1, 2, false)]
        [InlineData(1, 0, 2, true)]
        [InlineData(1.2, 1, 2, true)]
        [InlineData(-1.4, 0, 1, false)]
        [InlineData(-1.7, -1.7, -1, true)]
        [InlineData(2.9, 2, 4, true)]
        [InlineData(-2.2, -1, 2, false)]
        [InlineData(3.31, 2, 3.31, true)]
        [InlineData(-3.8, -4.7, 0.2, true)]
        public void TestCheckValuesInputDouble(double input, double min, double max, bool expected)
        {
            var check = new CheckValues();
            var actual = check.IsValidDouble(input, min, max);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("2", 0, 3, true)]
        [InlineData("-1", 0, 3, false)]
        [InlineData("r", 0, 3, false)]
        [InlineData("-1.2", -2, -1, false)]
        [InlineData("4.1", 4, 5, false)]
        [InlineData(" ", 4, 4, false)]
        public void TestInputInt(string item, int minValue, int maxValue, bool expected)
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
        public void TestInputDouble(string item, int minValue, int maxValue, bool expected)
        {
            var input = new InputValues();
            var actual = input.InputDouble(minValue, maxValue, item);
            Assert.Equal(expected, actual);
        }
    }
}
