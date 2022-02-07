namespace CourseApp.Tests
{
    using Xunit;

    public class TestTaskThree
    {
        private Dog _dog;
        private MilitaryDog _mildog;
        private MagicDog _magicdog;

        [Theory]
        [InlineData("Tommy", 12, 15, "Tommy|12|15")]
        [InlineData("Jack", -1, 2, "Jack|Incorrect|2")]
        public void TestDog(string name, int a, int weight, string expected)
        {
            _dog = new Dog(name, a, weight);
            Assert.Equal(expected, _dog.GetAll());
        }

        [Theory]
        [InlineData("Harry", 10, 20, "Mayor", 5, "Harry|10|20|Rank:Mayor|Militaryage:5")]
        [InlineData("Ronald", 10, 20, "Mayor", -1, "Ronald|10|20|Rank:Mayor|Militaryage:Invalid")]
        public void TestMilDog(string name, int age, int weight, string rank, int year, string expected)
        {
            _mildog = new MilitaryDog(name, age, weight, rank, year);
            Assert.Equal(expected, _mildog.GetAll());
        }

        [Theory]
        [InlineData("Richard", 500, 1, 300, 1000, 100, 100, "Richard|500|1|HP:1000|MANA:300|Stamina:100|Attack:100")]
        [InlineData("Azar", 1, 1000, 1, 10, 2, 2, "Azar|1|1000|HP:100|MANA:200|Stamina:100|Attack:20")]
        public void TestMagicDog(string name, int age, int weight, int mana, int helth, int attack, int stamina, string expected)
        {
            _magicdog = new MagicDog(name, age, weight, mana, helth, attack, stamina);
            Assert.Equal(expected, _magicdog.GetAll());
        }
    }
}
