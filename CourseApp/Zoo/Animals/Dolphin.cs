namespace CourseApp {
    using System;
    using CourseApp.Interfaces;

    public class Dolphin : Animals, IDrawable {
        public Dolphin(string name, string size, int age, string gender)
            : base(name, size, age, gender)
        {
            Name = name;
            Size = size;
            Age = age;
            Gender = gender;
        }

        public string Draw() {
            var inform = @$"Дельфин
            Имя: {Name}
            Размер: {Size}
            Возраст: {(Age <= 0 ? "none" : Age)}
            Пол: {Gender}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}