namespace CourseApp.Tests.ZooTests
{
    using CourseApp.Zoo.Animals;
    using Xunit;

    public class AnimalZoo
    {
        private Cat _cat;
        private Dog _dog;
        private Pony _pony;

        [Theory]
        [InlineData("Vasya", 18, "Male", "Cat: Name Vasya Age 18 Sex Male")]
        [InlineData("Antosha", 3, "Male", "Cat: Name Antosha Age 3 Sex Male")]
        [InlineData("Barsik", 2, "Male", "Cat: Name Barsik Age 2 Sex Male")]
        public void TestCat(string name, int age, string sex, string expected)
        {
            _cat = new Cat(name, age, sex);
            Assert.Equal(expected, _cat.Draw());
        }

        [Theory]
        [InlineData("Sharik", 5, "Male", "Dog: Name Sharik Age 5 Sex Male")]
        [InlineData("Busya", 4, "Female", "Dog: Name Busya Age 4 Sex Female")]
        [InlineData("Mark", 1, "Male", "Dog: Name Mark Age 1 Sex Male")]
        public void TestDog(string name, int age, string sex, string expected)
        {
            _dog = new Dog(name, age, sex);
            Assert.Equal(expected, _dog.Draw());
        }

        [Theory]
        [InlineData("RainbowDash", 9, "Female", "Pony: Name RainbowDash Age 9 Sex Female")]
        [InlineData("PinkyPie", 8, "Female", "Pony: Name PinkyPie Age 8 Sex Female")]
        [InlineData("Sparkle", 4, "Female", "Pony: Name Sparkle Age 4 Sex Female")]
        public void TestPony(string name, int age, string sex, string expected)
        {
            _pony = new Pony(name, age, sex);
            Assert.Equal(expected, _pony.Draw());
        }
    }
}