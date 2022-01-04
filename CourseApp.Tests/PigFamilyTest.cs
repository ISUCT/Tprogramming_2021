namespace CourseApp.Tests {
    using Xunit;

    public class PigFamilyTest {
        [Theory]
        [InlineData("Animals", "Animals")]
        [InlineData("Джорж", "Джорж")]
        public void TestName(string a, string exp) {
            Pig actualResult = new Pig(a, 0, 1);
            Assert.Equal(exp, actualResult.Name);
        }

        [Theory]
        [InlineData(88, 88)]
        [InlineData(-20, 0)]
        public void TestWeight(int a, int exp) {
            Pig actual = new Pig(" ", a, 10);
            Assert.Equal(exp, actual.Weight);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(-1, 0)]
        [InlineData(88, 88)]
        public void TestSalo(int a, int expected) {
            Pig actual = new Pig(" ", 0, a);
            Assert.Equal(expected, actual.Salo);
        }

        [Theory]
        [InlineData("Джорж", 5, "Из Джорж можно цепануть 5 сала\n")]
        [InlineData("Джорж", 0, "Джорж не даст сала\n")]
        public void TestToString(string n, int a, string expected) {
            Pig actual = new Pig(n, 8, a);
            Assert.Equal(expected, actual.ToString());
        }
    }
}