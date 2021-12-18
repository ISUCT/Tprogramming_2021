namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class BoarTest
    {
        [Theory]
        [InlineData("кабанчик Кабанистый", 5, "кабанчик Кабанистый убит\nПолучено 5 сала\n")]
        [InlineData("кабанчик Крутечок", 0, "кабанчик Крутечок убит\nПолучено 0 сала\n")]
        public void TestDiet(string n, int a, string exp)
        {
            Boar actualResult = new Boar(n, 0, 10, a);
            Assert.Equal(exp, actualResult.Died());
        }
    }
}