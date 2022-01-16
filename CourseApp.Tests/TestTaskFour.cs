namespace CourseApp.Tests
{
    using CourseApp.Zoo;
    using Xunit;

    public class TestTaskFour
    {
        private Creature _creature;
        private Worker _worker;
        private Driver _driver;
        private Car _car;
        private Cage _cage;
        private Shovel _shovel;

        [Theory]
        [InlineData("Sam", 20, "Lion", 44, 1, "In cage [#44] #1: Kind: Lion||Name: Sam||Age: 20years \n\n")]
        [InlineData("Tom", 5, "Tiger", 22, 2, "In cage [#22] #2: Kind: Tiger||Name: Tom||Age: 5years \n\n")]
        public void TestCreatureNCage(string name, int age, string kind, int id, int number, string ex)
        {
            _cage = new Cage(id, number);
            _creature = new Creature(name, age, kind);
            _creature.SetCage(_cage);
            Assert.Equal(ex, _cage.Draw());
        }

        [Theory]
        [InlineData("Sam", "Adams", 30, 5, "Opel", 412, "Model: Opel||Driver: Sam Adams: Age: 30 years||Exp: 5 years \n \n")]
        public void TestDriverNCar(string name, string sname, int age, int exp, string model, int id, string ex)
        {
            _car = new Car(id, model);
            _driver = new Driver(name, sname, age, exp);
            _driver.SetCar(_car);
            Assert.Equal(ex, _car.Draw());
        }

        [Theory]
        [InlineData("Vladimir", "Kojuhar", 30, 5, 123, 6, "Vladimir Kojuhar: Age: 30 years||Exp: 5 years \n||Staff: Shovel: [#123]||Number: 6")]
        public void TestWorkerNShovel(string name, string sname, int age, int exp, int id, int number, string ex)
        {
            _worker = new Worker(name, sname, age, exp);
            _shovel = new Shovel(id, number);
            _worker.SetShovel(_shovel);
            Assert.Equal(ex, _worker.Draw());
        }
    }
}
