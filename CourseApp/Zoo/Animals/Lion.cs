namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Lion : Animals, IDrawable
    {
        public Lion(string name, string size, int age, string sex, string mane)
            : base(name, size, age, sex)
        {
            Name = name;
            Size = size;
            Age = age;
            Sex = sex;
            Mane = mane;
        }

        public string Mane { get; set; }

        public string Draw()
        {
            var inform = @$"Лев
Имя: {Name}
Размерчик: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Sex}
Грива: {Mane}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}