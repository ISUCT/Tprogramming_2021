namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Bird : Animals, IDrawable
    {
        public Bird(string name, string size, int weight, int age, string sex, string food)
            : base(name, size, weight, age, sex)
        {
            Name = name;
            Size = size;
            Weight = weight;
            Age = age;
            Sex = sex;
            Food = food;
        }

        public string Food { get; set; }

        public string Draw()
        {
            var inform = @$"Птица

Имя: {Name}
Размер: {Size}
Вес: {(Weight <= 0 ? "imposible" : Weight)}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Sex}
Тип питания: {Food}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}