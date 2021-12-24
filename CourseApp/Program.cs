namespace CourseApp
{
    using System;
    using CourseApp.Interfaces;

    public class Program
    {
        public static void Main(string[] args)
        {
            PigFamily pigOne = new Pig();
            PigFamily pigTwo = new Pig("свинка Пеппа", 9, 99);
            Boar boarOne = new Boar("кабанчик Кабанистый", 1, 5, 7);
            Boar boarTwo = new Boar("кабанчик Крутечок", 3, 2, 8);
            PigFamily[] animals = new PigFamily[] { pigOne, pigTwo, boarOne, boarTwo };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.Write(pigTwo.Died());
            Console.WriteLine(pigTwo.MakePhrase());
            Console.Write(boarTwo.Died());
            Console.WriteLine(boarTwo.MakePhrase());
            Console.WriteLine("\n--------------------Зоопарк-----------------");
            var zoologicalGarden = new ZoologicalGarden("Ивановский\n");
            var user = new UserInterface();
            user.Draw(zoologicalGarden);
        }
    }
}