namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class PersonAgeCalculatorTests
    {
        [Theory]
        [InlineData(new[] { 2003, 5, 20 }, new[] { 2021, 5, 20 }, "You are 18th years.")]
        [InlineData(new[] { 2003, 5, 20 }, new[] { 2021, 11, 10 }, "You are 18 years, 5 months and 23 days")]
        [InlineData(new[] { 2003, 5, 20 }, new[] { 2022, 5, 3 }, "You are 18 years, 11 months and 14 days")]
        public void CalculatingAPersonsAge(int[] born, int[] end, string exp)
        {
            var mike = new PersonAgeCalculator();

            var res = mike.CalculatingAge(new DateTime(born[0], born[1], born[2]), new DateTime(end[0], end[1], end[2]));

            Assert.Equal(exp, res);
        }
    }
}