namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phraseArray = { "Грустно:(", "Как же печально:(", "Жалко животинку:(" };
            Pig pigOne = new Pig();
            Pig pigTwo = new Pig("свинка Пеппа", 9, 99);
            Boar boarOne = new Boar("кабанчик Кабанистый", 1, 5, 7);
            Boar boarTwo = new Boar("кабанчик Крутечок", 3, 2, 8);
            Animals[] animals = new Animals[] { pigOne, pigTwo, boarOne, boarTwo };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.Write(pigTwo.Died());
            Console.WriteLine(pigTwo.MakePhrase(phraseArray));
            Console.Write(boarTwo.Died());
            Console.WriteLine(boarTwo.MakePhrase(phraseArray));
        }
    }
}