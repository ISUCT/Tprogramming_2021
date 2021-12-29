namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Bird : Animals, IDrawable
    {
        public Bird(string name, string size, int age, string gender, string color)
            : base(name, size, age, gender)
        {
            Name = name;
            Size = size;
            Age = age;
            Gender = gender;
            Color = color;
        }

        public string Color { get; set; }

        public string Draw()
        {
            var inform = @$"Птица
Имя: {Name}
Размерчик: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Gender}
Цвет: {Color}";
            Console.WriteLine(inform);
            return " ";
        }
    }
} 