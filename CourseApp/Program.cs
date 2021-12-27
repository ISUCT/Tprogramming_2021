namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using CourseApp.Person;
    using Kantaiko.ConsoleFormatting;

    public class Program
    {
        public static void Main(string[] args)
        {
            var studentValera = new Student("Valera Sukharev", 18, 185);
            var studentAlesha = new Student("Aleksei Polekhin", 19, "Подвальный", 182);
            var employeeVladimir = new Employee("Vladimir Kozhukhar", 18, 185);
            var employeeUnknown = new Employee();
            Console.WriteLine(studentAlesha.Walk());
            Console.WriteLine(studentValera.Greeting());
            Console.WriteLine(employeeVladimir.ToString());
            Console.WriteLine(employeeUnknown.ToString());
        }
    }
}
