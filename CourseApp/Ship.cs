namespace CourseApp
{
    public abstract class Ship
    {
        private double size;
        private string color;
        private string material;

        public string Color { get; set; }

        public string Material { get; set; }

        public double Size
        {
            get
            {
                return size;
            }

            set
            {
                if (value > 0 && value < 100)
                {
                    size = value;
                }
            }
        }
    }
}
