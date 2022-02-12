namespace CourseApp.Tests
{
    using Xunit;

    public class AnimalsTest
    {
        [Theory]
        [InlineData("Animals", "Animals")]
        [InlineData("Бычок", "Бычок")]
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
        [InlineData("Бычок", 5, "Из Бычок можно получить 5 сала\n")]
        [InlineData("Бычок", 0, "Бычок Без сала\n")]
        public void TestToString(string n, int a, string expected)
        {
            Bull actual = new Bull(n, 8, a);
            Assert.Equal(expected, actual.ToString());
        }
    }
}