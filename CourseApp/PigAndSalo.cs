namespace CourseApp
{
    public class PigAndSalo
    {
        private string pig;
        private string salo;
        private int age;
        private int dateOfDeath;

        public PigAndSalo(string pig, string salo, string color, int age, int dateOfDeath)
        {
            Pig = pig;
            Salo = salo;
            Age = age;
            DateOfDeath = dateOfDeath;
        }

        public string Pig
        {
            get
            {
                return pig;
            }

            set
            {
                pig = value;
            }
        }

        public string Salo
        {
            get
            {
                return salo;
            }

            set
            {
                salo = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (age > 20)
                {
                    age = value;
                }
            }
        }

        public int DateOfDeath
        {
            get
            {
                return age;
            }

            set
            {
                if (dateOfDeath > 30)
                {
                    dateOfDeath = value;
                }
            }
        }
    }
}
