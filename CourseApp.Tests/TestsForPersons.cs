namespace CourseApp.Tests
{
    using CourseApp.Person;
    using Xunit;

    public class TestsForPersons
    {
        private Student _student;
        private Employee _employee;

        [Theory]
        [InlineData("Vladimir Kozhukhar", 18, "Male", 185, "Student: Vladimir Kozhukhar 18 y.o. Male 185 sm")]
        [InlineData("Mark Rumyantsev", 19, "Male", 174, "Student: Mark Rumyantsev 19 y.o. Male 174 sm")]
        [InlineData("Aleksandr Kirillov", 19, "Male", 188, "Student: Aleksandr Kirillov 19 y.o. Male 188 sm")]
        public void TestStudent(string name, int age, string gender, int height, string expected)
        {
            _student = new Student(name, age, gender, height);
            Assert.Equal(expected, _student.ToString());
        }

        [Theory]
        [InlineData("Nikita Ryibkin", 18, "Male", 180, "Employee: Nikita Ryibkin 18 y.o. Male 180 sm")]
        [InlineData("Yaroslav Vdovin", 18, "Male", 174, "Employee: Yaroslav Vdovin 18 y.o. Male 174 sm")]
        [InlineData("Daniil Golubev", 19, "Male", 175, "Employee: Daniil Golubev 19 y.o. Male 175 sm")]
        public void TestEmployee(string name, int age, string gender, int height, string expected)
        {
            _employee = new Employee(name, age, gender, height);
            Assert.Equal(expected, _employee.ToString());
        }
    }
}