namespace CourseApp.Tests {
    using System;
    using Xunit;

    public class WarthogTest {
        [Theory]
        [InlineData("Стефан", 5, "Стефан заколот\nПолучено 5 сала\n")]
        [InlineData("Пармезан", 0, "Пармезан заколот\nПолучено 0 сала\n")]
        public void TestDiet(string n, int a, string exp) {
            Warthog actualResult = new Warthog(n, 0, 10, a);
            Assert.Equal(exp, actualResult.Died());
        }
    }
}