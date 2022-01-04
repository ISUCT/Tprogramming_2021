namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class UnitTests
    {
        [Theory]
        [InlineData(2021, 10, 15, 2002, 4, 24, "19 5 21")]
        [InlineData(2021, 10, 15, 2006, 4, 21, "15 5 24")]
        [InlineData(2021, 10, 15, 2012, 5, 24, "9 4 21")]
        public void TestAge(int todayYear, int todayMonth, int todayDay, int birthYear, int birthMonth, int birthDay, string expected)
        {
            DateTime birth = new DateTime(birthYear, birthMonth, birthDay);
            DateTime today = new DateTime(todayYear, todayMonth, todayDay);
            var dateClass = new DateClass();
            var date = dateClass.CalculateAge(birth, today);
            var actual = $"{date.Item1} {date.Item2} {date.Item3}";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2021, 10, 15, 2002, 4, 24, "6 9")]
        [InlineData(2021, 10, 15, 2006, 4, 21, "6 6")]
        [InlineData(2021, 10, 15, 2012, 5, 24, "7 9")]
        public void TestDaysToBirthDay(int todayYear, int todayMonth, int todayDay, int birthYear, int birthMonth, int birthDay, string expected)
        {
            DateTime birth = new DateTime(birthYear, birthMonth, birthDay);
            DateTime today = new DateTime(todayYear, todayMonth, todayDay);
            var dateClass = new DateClass();
            var date = dateClass.CalculateDaysToBirthDay(birth, today);
            var actual = $"{date.Item1} {date.Item2}";
            Assert.Equal(expected, actual);
        }
    }
}
