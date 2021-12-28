namespace CourseApp.Zoo.Animals
{
    public class Pony : Animal, IDrawable
    {
        public Pony(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public string Draw()
        {
            return $"Pony: Name {Name} Age {Age} Sex {Sex}";
        }
    }
}