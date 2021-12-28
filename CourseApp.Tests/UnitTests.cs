namespace CourseApp.Tests
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Program;
    using Xunit;
    using static System.Math;

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
        [InlineData(2021, 10, 15, 2002, 4, 24, "19 year`s 5 month`s 21 day ")]
        [InlineData(2021, 10, 15, 2006, 4, 21, "15 year`s 5 month`s 24 day`s")]
        [InlineData(2021, 10, 15, 2012, 5, 24, "9 year`s 4 month`s 21 day ")]
        public void TestCreateOutputAge(int todayYear, int todayMonth, int todayDay, int birthYear, int birthMonth, int birthDay, string expected)
        {
            DateTime birth = new DateTime(birthYear, birthMonth, birthDay);
            DateTime today = new DateTime(todayYear, todayMonth, todayDay);
            var dateClass = new DateClass();
            var date = dateClass.CreateOutput(dateClass.CalculateAge(birth, today));
            var actual = $"{date.Item1} {date.Item2} {date.Item3}";
          Assert.Equal(expected, actual.ToArray());
        }
  
        [Theory]
        [InlineData(3, 2, 0.11, 1.56)]
        [InlineData(3, 2, 0.36, 1.488)]
        [InlineData(3, 2, 0.08, 1.565)]
        [InlineData(3, 2, 0.026, 1.57)]
        [InlineData(3, 2, 0.35, 1.491)]
        [InlineData(3, 2, 0.41, 1.471)]
        [InlineData(3, 2, 0.51, 1.441)]
        public void TestCalculate(double a, double b, double x, double expected)
        {
            var task = new CalculateTasks(a, b);
            var (_, actual) = task.CalculateValue(x);
            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [InlineData(0.1, 0.5, 0.1, 5)]
        [InlineData(0, 5, 1, 6)]
        [InlineData(0.25, 0.5, 0.05, 6)]
        [InlineData(1.2, 2.4, 1.2, 2)]
        public void TestListCount(double start, double end, double delta, int expected)
        {
            var task = new CalculateTasks(start, end, delta);
            var actual = task.ListValue().Count;
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

        [Theory]
        [InlineData(2021, 10, 15, 2002, 4, 24, "6 month`s 9 day`s to your birthDay")]
        [InlineData(2021, 10, 15, 2006, 10, 15, "  Happy birthDay!")]
        [InlineData(2021, 10, 15, 2012, 10, 14, " 1 day from your birthDay")]
        public void TestCreateOutputDaysToBirthDay(int todayYear, int todayMonth, int todayDay, int birthYear, int birthMonth, int birthDay, string expected)
        {
            DateTime birth = new DateTime(birthYear, birthMonth, birthDay);
            DateTime today = new DateTime(todayYear, todayMonth, todayDay);
            var dateClass = new DateClass();
            var date = dateClass.CreateOutput(dateClass.CalculateDaysToBirthDay(birth, today));
            var actual = $"{date.Item1} {date.Item2} {date.Item3}";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 3, 0.1, 0.5, 0.1, new double[] { 1.58, 1.603, 1.634, 1.667, 1.698 })]
        [InlineData(2, 3, 3, 9, 3, new double[] { double.NaN, double.NaN, double.NaN })]
        [InlineData(2, 3, 0.5, 2.5, 0.5, new double[] { 1.698, 1.571, double.NaN, double.NaN, double.NaN })]
        public void TestTaskOne(double a, double b, double start, double end, double delta, double[] expected)
        {
            var task = new CalculateTasks(a, b, start, end, delta);
            var list = task.ListValue();
            var actual = new List<double>();
            foreach (var item in list)
            {
                actual.Add(Round(task.CalculateValue(item).Item2, 3));
            }

            Assert.Equal(expected, actual.ToArray());
        }

        [Theory]
        [InlineData(2, 3, new double[] { 1, 2, 3, 4 }, new double[] { 1.571, double.NaN, double.NaN, double.NaN })]
        [InlineData(2, 3, new double[] { 0.1, 0.2, 0.3, 0.4 }, new double[] { 1.58, 1.603, 1.634, 1.667 })]
        [InlineData(2, 3, new double[] { 0.5, 0.75, 0.8, 0.9 }, new double[] { 1.698, 1.733, 1.728, 1.698 })]
        public void TestTaskTwo(double a, double b, double[] list, double[] expected)
        {
            var task = new CalculateTasks(a, b);
            var actual = new List<double>();
            foreach (var item in list)
            {
                actual.Add(Round(task.CalculateValue(item).Item2, 3));
            }
          
           Assert.Equal(expected, actual.ToArray());
        }
    }
}
