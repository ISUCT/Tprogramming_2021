namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Lion : Animals, IDrawable
    {
        public Lion(string name, string size, int weight, int age, string sex)
            : base(name, size, weight, age, sex)
        {
            Name = name;
            Size = size;
            Weight = weight;
            Age = age;
            Sex = sex;
        }

        public string Draw()
        {
            var inform = @$"Лев
Кличка: {Name}
Размер: {Size}
Вес: {(Weight <= 0 ? "imposible" : Weight)}
Возраст: {(Age <= 0 ? "imposible" : Age)}
Пол: {Sex}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}