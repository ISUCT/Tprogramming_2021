namespace CourseApp.Zoo.People
{
    public abstract class Person : IPerson
    {
        private int age;

        public Person(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public int Age
        {
            get => age;

            set => age = value is >= 0 and < 100 ? value : 0;
        }

        public string Sex { get; set; }
    }
}
