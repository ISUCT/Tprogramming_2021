namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Guest : People, IDrawable
    {
        public Guest(string name, int age, string sex)
            : base(name, age, sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
        }

        public string Draw()
        {
            var inform = @$"Посетитель
Имя: {Name}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Sex}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}