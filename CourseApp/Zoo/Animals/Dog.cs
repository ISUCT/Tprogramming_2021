namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Dog : Animals, IDrawable
    {
        public Dog(string name,  string size, int weight, int age, string sex, string breed)
            : base(name, size, weight, age, sex)
        {
            Name = name;
            Size = size;
            Weight = weight;
            Age = age;
            Sex = sex;
            Breed = breed;
        }

        public string Breed { get; set; }

        public string Draw()
        {
            var inform = @$"Собачка
Кличка: {Name}
Размер: {Size}
Вес: {(Weight <= 0 ? "imposible" : Weight)}
Возраст: {(Age <= 0 ? "imposible" : Age)}
Пол: {Sex}
Порода: {Breed}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}