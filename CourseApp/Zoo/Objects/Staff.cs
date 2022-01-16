namespace CourseApp.Zoo.Objects
{
    public abstract class Staff : IStaff
    {
        public Staff(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}