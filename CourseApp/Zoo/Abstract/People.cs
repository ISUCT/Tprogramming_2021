namespace CourseApp
{
    public abstract class People
    {
        public People(string name, int age, string sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }
    }
}