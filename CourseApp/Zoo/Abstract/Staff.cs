namespace CourseApp
{
    public abstract class Staff
    {
        public Staff(string role, string size, string material)
        {
            Role = role;
            Size = size;
            Material = material;
        }

        public string Role { get; set; }

        public string Size { get; set; }

        public string Material { get; set; }
    }
}