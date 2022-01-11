namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Fish : Animals, IDrawable
    {
        public Fish(string name, string size, int age, string sex)
            : base(name, size, age, sex)
        {
            Name = name;
            Size = size;
            Age = age;
            Sex = sex;
        }

        public string Draw()
        {
            var inform = @$"Рыбка
Имя: {Name}
Размер: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Sex}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}