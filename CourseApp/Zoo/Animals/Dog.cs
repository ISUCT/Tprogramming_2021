namespace CourseApp.Zoo.Animals
{
    using CourseApp.Zoo.Interfaces;

    public class Dog : Animal, IDrawable
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public override string Draw()
        {
            return $"Dog: Name {Name} Age {Age} Sex {Sex}";
        }
    }
}