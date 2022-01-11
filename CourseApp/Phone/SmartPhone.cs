namespace CourseApp
{
    public abstract class SmartPhone : CellPhone
    {
        private float diagonal = 0;

        public float Diagonal
        {
            get
            {
                return diagonal;
            }

            set
            {
                if (value > 0)
                {
                    diagonal = value;
                }
            }
        }
    }
}
