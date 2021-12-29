namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Visitor : People, IDrawable
    {
        public Visitor(string name, int age)
            : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string Draw()
        {
            var inform = @$"Гость
Имя: {Name}
Возраст: {(Age <= 0 ? "none" : Age)}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}