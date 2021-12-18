namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class PigTest
    {
        [Theory]
        [InlineData("Свинка Пеппа", 5, "Свинка Пеппа зарезана\nПолучено 5 сала\n")]
        [InlineData("Свинка Пеппа", 0, "Свинка Пеппа зарезана\nПолучено 0 сала\n")]
        public void TestDiet(string n, int a, string exp)
        {
            Pig actualResult = new Pig(n, 0, a);
            Assert.Equal(exp, actualResult.Died());
        }
    }
}