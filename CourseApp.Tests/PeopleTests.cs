namespace CourseApp.Tests
{
    using System;
    using Xunit;

    public class PeopleTests
    {
        private Guest _guest;
        private Employee _employee;
        [Theory]
        [InlineData("Cheidze Marta", 20, "Female")]
        [InlineData("Tropova Violetta", 32, "Female")]

        public void TestGuest(string name, int age, string sex, string expected)
        {
            _guest = new Guest(name, age, sex);
            Assert.Equal(expected, _guest.ToString());
        }

        [Theory]
        [InlineData("Alex Polehin", 19, "Male", "Сleaner", 19500)]
        [InlineData("Rymencev Mark", 41, "Male", "Gide", 35000)]

        public void TestEmployee(string name, int age, string sex, string position, int salary, string expected)
        {
            _employee = new Employee(name, age, sex, position, salary);
            Assert.Equal(expected, _employee.ToString());
        }
    }
}