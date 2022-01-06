 namespace CourseApp
{
    using System;
    /* using System.Collections.Generic;*/

    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phraseArray = { "Нет свинки" };
            Pig pigOne = new Pig();
            Pig pigTwo = new Pig("Свинка", 9, 99);
            Deer deerOne = new Deer("Олень 1", 1, 5, 7);
            Deer deerTwo = new Deer("Олень 2", 3, 2, 8);
            Animals[] animals = new Animals[] { pigOne, pigTwo, deerOne, deerTwo };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.Write(pigTwo.Died());
            Console.WriteLine(pigTwo.MakePhrase(phraseArray));
            Console.Write(deerTwo.Died());
            Console.WriteLine(deerTwo.MakePhrase(phraseArray));
        }
    }
}
