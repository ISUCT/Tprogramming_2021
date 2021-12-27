namespace CourseApp.Person
{
    public abstract class Person : IPerson
    {
        private int age;

        private int height;

        public Person(string name, int age, string gender, int height)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
        }

        public Person()
            : this("Someone", 0, "Ukrainian drone", 0)
        {
        }

        public Person(string name, int age, string gender)
            : this(name, age, gender, 0)
        {
        }

        public Person(string name, int age, int height)
            : this(name, age, "Ukrainian drone", height)
        {
        }

        public Person(string name, int age)
            : this(name, age, "Ukrainian drone", 0)
        {
        }

        public Person(string name)
            : this(name, 0, "Ukrainian drone", 0)
        {
        }

        public string Name { get; set; }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value >= 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public string Gender { get; set; }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value > 100 && value < 250)
                {
                    height = value;
                }
                else
                {
                    height = 100;
                }
            }
        }

        public abstract string Walk();

        public abstract string Greeting();

        public override string ToString()
        {
            return $"Person {Name} is living";
        }
    }
}
