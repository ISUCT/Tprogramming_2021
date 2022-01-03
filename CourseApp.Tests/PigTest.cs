namespace CourseApp.Tests {
    using System;
    using Xunit;

    public class PigTest {
        [Theory]
        [InlineData("Джорж", 5, "Джорж заколот\nПолучено 5 сала\n")]
        [InlineData("Джорж", 0, "Джорж заколот\nПолучено 0 сала\n")]
        public void TestDiet(string n, int a, string exp) {
            Pig actualResult = new Pig(n, 0, a);
            Assert.Equal(exp, actualResult.Died());
        }
    }
}