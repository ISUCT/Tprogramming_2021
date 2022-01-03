namespace CourseApp {
    using System;
    using CourseApp.Interfaces;

    public class Worker : People, IDrawable {
        public Worker(string name, string jobPlace, int age)
            : base(name, age)
        {
            Name = name;
            JobPlace = jobPlace;
            Age = age;
        }

        public string JobPlace { get; set; }

        public string Draw() {
            var inform = @$"Работник
            Имя: {Name}
            Должность: {JobPlace}
            Возраст: {(Age <= 0 ? "none" : Age)}";
            Console.WriteLine(inform);
            return " ";
        }
    }
}
