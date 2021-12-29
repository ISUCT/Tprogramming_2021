namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Fish : Animals, IDrawable
    {
        public Fish(string name, string size, int age, string gender)
            : base(name, size, age, gender)
        {
            Name = name;
            Size = size;
            Age = age;
            Gender = Gender;
        }

        public string Draw()
        {
            var inform = @$"Рыба
Имя: {Name}
Размер: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Gender}";
            Console.WriteLine(inform);
            return " ";
        }
    }
} 