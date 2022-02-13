namespace CourseApp
{
    public abstract class Staff
    {
        public Staff(string title, string color, string material, string mission)
        {
            Title = title;
            Color = color;
            Material = material;
            Mission = mission;
        }

        public string Title { get; set; }

        public string Color { get; set; }

        public string Material { get; set; }

        public string Mission { get; set; }
    }
}