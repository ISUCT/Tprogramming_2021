namespace CourseApp
{
    using System;

    public class Dog
    {
        private string name;
        private int age;
        private double weight;

        public Dog(string name, int age, double weight)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                this.age = 0;
            }

            if (weight > 0)
            {
                this.weight = weight;
            }
            else
            {
                this.weight = 0;
            }

            this.name = name;
        }

        public Dog(string name, int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                this.age = 0;
            }

            this.name = name;
            weight = 0;
        }

        public void SetAge(int s)
        {
            if (s > 0)
            {
                age = s;
            }
            else
            {
                age = 0;
            }
        }

        public string ShowVoice()
        {
            return "woof woof";
        }

        public int GetAge()
        {
            return age;
        }

        public string GetAll()
        {
            string name = this.name;
            string age = "Incorrect";
            string weight = "Incorrect";
            if (this.age > 0)
            {
                age = Convert.ToString(this.age);
            }

            if (this.weight > 0)
            {
                weight = Convert.ToString(this.weight);
            }

            string s = name + "|" + Convert.ToString(age) + "|" + weight;
            return s;
        }
    }
}
