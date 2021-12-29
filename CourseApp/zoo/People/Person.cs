namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Person : People, IDrawable
    {
        public Person(string name, string post, int age)
            : base(name, age)
        {
            Name = name;
            Post = post;
            Age = age;
        }

        public string Post { get; set; }

        public string Draw()
        {
            var inform = @$"Работник
Имя: {Name}
Должность: {Post}
Возраст: {(Age <= 0 ? "none" : Age)}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}