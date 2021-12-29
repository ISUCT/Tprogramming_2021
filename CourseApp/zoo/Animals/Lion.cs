namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Lion : Animals, IDrawable
    {
        public Lion(string name, string size, int age, string gender, string breed)
            : base(name, size, age, gender)
        {
            Name = name;
            Size = size;
            Age = age;
            Gender = gender;
            Breed = breed;
        }

        public string Breed { get; set; }

        public string Draw()
        {
            var inform = @$"Лев
Имя: {Name}
Размерчик: {Size}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Gender}
Порода: {Breed}";
            Console.WriteLine(inform);
            return " ";
        }
    }
} 