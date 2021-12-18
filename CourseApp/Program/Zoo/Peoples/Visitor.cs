namespace CourseApp.Program.Zoo.Peoples
{
    using System;
    using CourseApp.Program.Interface;
    using CourseApp.Program.Zoo.Abstract;

    public class Visitor : People, IDrawable
    {
        public Visitor(string name, int age)
            : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public void Draw()
        {
            var information = @$"  Class: Employee
    Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)}
    Age: {(string.IsNullOrEmpty(Age.ToString()) ? "none" : Age)}y
    ";
            Console.WriteLine(information);
        }
    }
}