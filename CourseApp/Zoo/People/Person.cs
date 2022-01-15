namespace CourseApp.Zoo.People
{
    using CourseApp.Zoo.Interfaces;

    public abstract class Person : IPerson, IDrawable
    {
        private int _age;

        public Person(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public int Age
        {
            get => _age;

            set => _age = value is >= 0 and < 100 ? value : 0;
        }

        public string Sex { get; set; }

        public abstract string Draw();
    }
}