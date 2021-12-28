namespace CourseApp.Zoo.Animals
{
    public class Cat : Animal, IDrawable
    {
        public Cat(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public string Draw()
        {
            return $"Cat: Name {Name} Age {Age} Sex {Sex}";
        }
    }
}