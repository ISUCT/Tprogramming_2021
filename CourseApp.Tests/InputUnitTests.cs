namespace CourseApp.Tests
{
    using System;
    using CourseApp.Program;
    using CourseApp.Program.Input;
    using Xunit;

    public class InputUnitTests
    {
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
