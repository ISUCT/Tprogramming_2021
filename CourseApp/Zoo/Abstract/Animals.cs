namespace CourseApp
{
    public abstract class Animals
    {
        public Animals(string name, string size, int weight, int age, string sex)
        {
            Name = name;
            Size = size;
            Weight = weight;
            Age = age;
            Sex = sex;
        }

        public string Name { get; set; }

        public string Size { get; set; }

        public int Weight { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }
    }
}