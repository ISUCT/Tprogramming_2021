namespace CourseApp
{
    /* using System; */
    /* using System.Collections.Generic;*/

    public abstract class Animals
    {
        private int lard;
        private int weight;
        private int age;

        public Animals()
        : this("неизвестного животного", 10, 12, 13)
        {
        }

        public Animals(string name, int weight)
        : this(name, weight, 0, 0)
        {
        }

        public Animals(string name, int weight, int lard)
        : this(name, weight, 0, lard)
        {
        }

        public Animals(string name, int weight, int age, int lard)
        {
            Name = name;
            Lard = lard;
            Age = age;
            Weight = weight;
        }

        public string Name
        {
            get;
            set;
        }

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value < 0)
                {
                    weight = 0;
                }
                else
                {
                    weight = value;
                }
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
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }

        public int Lard
        {
            get
            {
                return lard;
            }

            set
            {
                if (value < 0)
                {
                    lard = 0;
                }
                else
                {
                    lard = value;
                }
            }
        }

        public override string ToString()
        {
            if (lard == 0)
            {
                return $"{Name} Без сала\n";
            }
            else
            {
                return $"Из {Name} можно получить {Lard} сала\n";
            }
        }

        public abstract string Died();

        public abstract string MakePhrase(string[] phraseArray);
    }
}