namespace CourseApp.Tests.ZooTests
{
    using CourseApp.Zoo.People;
    using Xunit;

    public class PeopleZoo
    {
        private Visitor _visitor;
        private Employee _employee;

        [Theory]
        [InlineData("Vladimir Kozhulhar", 18, "Male", "In zoo has come a new visitor: Name Vladimir Kozhulhar Age 18")]
        [InlineData("Maksim Silin", 19, "Male", "In zoo has come a new visitor: Name Maksim Silin Age 19")]
        public void TestVisitor(string name, int age, string sex, string expected)
        {
            _visitor = new Visitor(name, age, sex);
            Assert.Equal(expected, _visitor.Draw());
        }

        [Theory]
        [InlineData("Ruslan Polyakov", 19, "Male", "Administrator", "Employee: Name Ruslan Polyakov Age 19 Post Administrator")]
        [InlineData("Nikita Ezhov", 22, "Male", "Cleaner", "Employee: Name Nikita Ezhov Age 22 Post Cleaner")]
        [InlineData("Artem Boyarkin", 19, "Male", "Worker", "Employee: Name Artem Boyarkin Age 19 Post Worker")]
        public void TestEmployee(string name, int age, string sex, string post, string expected)
        {
            _employee = new Employee(name, age, sex, post);
            Assert.Equal(expected, _employee.Draw());
        }
    }
}