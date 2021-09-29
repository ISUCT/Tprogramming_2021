namespace CourseApp1
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Hello world");
            var position = new ProgramDish("Cheesecake", 130, 200);
            var position2 = new ProgramDish();

            Console.WriteLine($"Name: {position.Name}, Weight: {position.Weight} g, Price: {position.Price} rub");

            Console.WriteLine($"Name: {position2.Name}, Weight: {position2.Weight} g, Price: {position2.Price} rub");

            Console.ReadLine();
        }
    }
}
