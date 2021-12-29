namespace CourseApp
{
    public abstract class Animals
    {
        public Animals(string name, string size, int age, string gender)
        {
            Name = name;
            Size = size;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }

        public string Size { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }
}