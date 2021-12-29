namespace CourseApp
{
    public abstract class Staff
    {
        public Staff(string designation, string type, string material)
        {
            Designation = designation;
            Type = type;
            Material = material;
        }

        public string Designation { get; set; }

        public string Type { get; set; }

        public string Material { get; set; }
    }
}