namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Clovenhoofed : Animals, IDrawable
    {
        public Clovenhoofed(string name,  string size, int weight, int age, string sex, string horns)
            : base(name, size, weight, age, sex)
        {
            Name = name;
            Size = size;
            Weight = weight;
            Age = age;
            Sex = sex;
            Horns = horns;
        }

        public string Horns { get; set; }

        public string Draw()
        {
            var inform = @$"Парнокопытное
Кличка: {Name}
Размер: {Size}
Вес: {(Weight <= 0 ? "imposible" : Weight)}
Возраст: {(Age <= 0 ? "imposible" : Age)}
Пол: {Sex}
Рога: {Horns}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}