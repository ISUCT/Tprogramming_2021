namespace CourseApp.Tests
{
    using CourseApp.Person;
    using Xunit;

    public class TestsForPersons
    {
        [Fact]
        public void GetNameOfStudent()
        {
            var student = new Student("Anatoliy Rumyantsev", 18, "Clown", 192);
            var expected = "Anatoliy Rumyantsev";
            Assert.Equal(expected, student.Name);
        }

        [Fact]
        public void GetAgeOfStudent()
        {
            var student = new Student("Sergey Vasiliev", 25, "c400", 165);
            var expected = 25;
            Assert.Equal(expected, student.Age);
        }

        [Fact]
        public void GetGenderOfEmployee()
        {
            var employee = new Employee("Stas Tereshenko", 45, "T34", 180);
            var expected = "T34";
            Assert.Equal(expected, employee.Gender);
        }

        [Fact]
        public void GetHeightOfEmployee()
        {
            var employee = new Employee("Anastasiya Kruchevskaya", 33, 174);
            var expected = 174;
            Assert.Equal(expected, employee.Height);
        }
    }
}