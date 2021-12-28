namespace CourseApp.Person
{
    using System;

    public class Student : Person
    {
        public Student()
            : base()
        {
        }

        public Student(string name, int age, string gender)
            : base(name, age, gender)
        {
        }

        public Student(string name, int age, string gender, int height)
            : base(name, age, gender, height)
        {
        }

        public Student(string name, int age, int height)
            : base(name, age, height)
        {
        }

        public Student(string name)
            : base(name)
        {
        }

        public Student(string name, int age)
            : base(name, age)
        {
        }

        public override string Walk()
        {
            return "I`m walking";
        }

        public override string Greeting()
        {
            return $"Hello, my name is {Name} and I`m {Age} old.";
        }

        public void Study()
        {
            throw new NotImplementedException();
        }
    }
}