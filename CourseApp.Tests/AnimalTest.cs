namespace CourseApp.Tests
{
    using Xunit;

    public class AnimalsTest
    {
        [Theory]
        [InlineData("Animals", "Animals")]
        [InlineData("Свинка", "Свинка")]
        public void TestName(string a, string exp)
        {
            Pig actualResult = new Pig(a, 1);
            Assert.Equal(exp, actualResult.Name);
        }

        [Theory]
        [InlineData(88, 88)]
        [InlineData(-20, 0)]
        public void TestWeight(int a, int exp)
        {
            Pig actual = new Pig(" ", a);
            Assert.Equal(exp, actual.Weight);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(88, 88)]
        public void TestFat(int a, int expected)
        {
            Pig actual = new Pig(" ", 0, a);
            Assert.Equal(expected, actual.Lard);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(8, 8)]
        public void TestAge(int a, int expected)
        {
            Pig actual = new Pig(" ", 0, a, 88);
            Assert.Equal(expected, actual.Age);
        }

        [Theory]
        [InlineData("Свинки", 5, "Свинка содержил 5 сала\n")]
        [InlineData("Свинки", 0, "Свинка не имеет сала\n")]
        public void TestToString(string n, int a, string expected)
        {
            Pig actual = new Pig(n, 8, a);
            Assert.Equal(expected, actual.ToString());
        }
    }
}