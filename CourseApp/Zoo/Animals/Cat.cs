namespace CourseApp.Zoo.Animals
{
    using CourseApp.Zoo.Interfaces;

    public class Cat : Animal, IDrawable
    {
        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public override string Draw()
        {
            return $"Cat: Name {Name} Age {Age} Sex {Sex}";
        }
    }
}