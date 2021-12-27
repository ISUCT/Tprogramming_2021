namespace CourseApp.Person
{
    using System;

    public class Employee : Person
    {
        public Employee()
            : base()
        {
        }

        public Employee(string name, int age, string gender, int height)
            : base(name, age, gender, height)
        {
        }

        public Employee(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public Employee(string name, int age, int height)
            : base(name, age, height)
        {
        }

        public Employee(string name)
            : base(name)
        {
        }

        public Employee(string name, int age)
            : base(name, age)
        {
        }

        public override string Walk()
        {
            return "Whoooooooooooo, I`m walking";
        }

        public override string Greeting()
        {
            return $"Hi! What`s your name? My my name is {Name} and I`m {Age} old.";
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
