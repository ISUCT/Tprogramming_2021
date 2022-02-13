namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Employee : People, IDrawable
    {
        public Employee(string name, int age, string sex, string position, int salary)
            : base(name, age, sex)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Position = position;
            Salary = salary;
        }

        public string Position { get; set; }

        public int Salary { get; set; }

        public string Draw()
        {
            var inform = @$"Сотрудник
Имя: {Name}
Возраст: {(Age <= 0 ? "none" : Age)}
Пол: {Sex}
Должность: {Position}
Зарплата: {Salary}";

            Console.WriteLine(inform);
            return " ";
        }
    }
}