namespace CourseApp.Zoo.People
{
    using CourseApp.Zoo.Interfaces;

    public class Employee : Person, IDrawable
    {
        public Employee(string name, int age, string sex, string post)
            : base(name, age, sex)
        {
            Post = post;
        }

        private string Post { get; set; }

        public override string Draw()
        {
            return $"Employee: Name {Name} Age {Age} Post {Post}";
        }
    }
}