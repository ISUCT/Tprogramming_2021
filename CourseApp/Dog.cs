namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Dog : Animals, IDrawable
    {
        public Dog(string name, string size, int age, string sex, string breed)
            : base(name, size, age, sex)
        {
            Name = name;
            Size = size;
            Age = age;
            Sex = sex;
            Breed = breed;
        }

        public string Breed { get; set; }

        public string Draw()
        {
            var inform = @$"Собачка
Имя: {Name}
Размерчик: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Sex}
Порода: {Breed}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}