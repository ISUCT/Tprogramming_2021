namespace CourseApp.Tests
{
    using Xunit;

    public class TestTaskTwo
    {
        private readonly TaskTwo _taskTwo;

        public TestTaskTwo()
        {
            _taskTwo = new TaskTwo();
        }

        [Theory]
        [InlineData("10.13.2002", "Incorrect Data")]
        [InlineData("10.13.20fa", "Incorrect Data")]
        [InlineData("fa.awe.2fas2", "Incorrect Data")]
        [InlineData("0.0.0", "Incorrect Data")]
        [InlineData("10.13.20012312", "Incorrect Data")]
        [InlineData("10.10.2002", "The birthday in the past.")]
        [InlineData("10.01.1955", "The birthday in the past.")]
        [InlineData("05.11.2030", "The birthday in the future.")]
        [InlineData("01.10.2222", "The birthday in the future.")]
        [InlineData("31.01.2022", "The birthday today.")]
        public void RunTest(string s, string expected)
        {
            _taskTwo.InitData(s);
            string res = _taskTwo.Check();
            Assert.Equal(expected, res);
        }
    }
}
