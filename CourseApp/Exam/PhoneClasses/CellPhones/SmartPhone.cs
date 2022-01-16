namespace CourseApp.Exam.PhoneClasses.CellPhones
{
    using CourseApp.Exam.Interfaces;

    public abstract class SmartPhone : CellPhone, ISmartPhone
    {
        private float _diagonal;

        public float Diagonal
        {
            get
            {
                return _diagonal;
            }

            set
            {
                if (value >= 0f)
                {
                    _diagonal = value;
                }
                else
                {
                    _diagonal = 0f;
                }
            }
        }
    }
}