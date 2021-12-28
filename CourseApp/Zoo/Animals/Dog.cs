namespace CourseApp.Zoo.Animals
{
    public class Dog : Animal, IDrawable
    {
        public Dog(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public string Draw()
        {
            return $"Dog: Name {Name} Age {Age} Sex {Sex}";
        }
    }
}