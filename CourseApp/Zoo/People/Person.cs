namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Person : People, IDrawable
    {
        public Person(string name, string position, int age)
            : base(name, age)
        {
            Name = name;
            Position = position;
            Age = age;
        }

        public string Position { get; set; }

        public string Draw()
        {
            var inform = @$"Работник
Имя: {Name}
Должность: {Position}
Возраст: {(Age <= 0 ? "none" : Age)}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}
