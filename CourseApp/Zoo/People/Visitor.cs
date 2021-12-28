namespace CourseApp.Zoo.People
{
    public class Visitor : Person, IDrawable
    {
        public Visitor(string name, int age, string sex)
            : base(name, age, sex)
        {
        }

        public string Draw()
        {
            return $"In zoo has come a new visitor: Name {Name} Age {Age}";
        }
    }
}