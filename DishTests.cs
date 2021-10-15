namespace CourseApp.Tests
{
    using Xunit;

    public class DishTests
    {
        [Fact]
        public void GetNewCake()
        {
            var food = new DishClass();
            var res = food.ProgramDish("Cake", 900, 1500);
            var exp = "Cake";

            Assert.Equal(exp, food.Name);
        }

        [Fact]
        public void GetNewTiramisu()
        {
            var food = new DishClass();
            var res = food.ProgramDish("Tiramisu", 250, 350);
            var exp = 250;

            Assert.Equal(exp, food.Weight);
        }

        [Fact]
        public void GetNewPannacotta()
        {
            var food = new DishClass();
            var res = food.ProgramDish("Pannacotta", 200, 300);
            var exp = 300;

            Assert.Equal(exp, food.Price);
        }
    }
}