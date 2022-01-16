namespace CourseApp.Zoo
{
    public abstract class Staff
    {
        private int id = -1;

        public Staff(int id)
        {
            if (id > 0)
            {
                this.id = id;
            }
        }

        public string GetID()
        {
            return $"[#{id}]";
        }
    }
}
