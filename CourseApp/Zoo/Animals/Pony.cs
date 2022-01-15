namespace CourseApp.Zoo.Animals
{
    using CourseApp.Zoo.Interfaces;

    public class Pony : Animal, IDrawable
    {
        public Pony(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public override string Draw()
        {
            return $"Pony: Name {Name} Age {Age} Sex {Sex}";
        }
    }
}