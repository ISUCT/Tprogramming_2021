namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Boar : PigFamily
    {
        private Random random = new Random();

        public Boar()
        : base()
        {
        }

        public Boar(string name, int weight, int age, int lard)
        : base(name, weight, age, lard)
        {
        }

        public override string Died()
        {
            int lard = Lard;
            return $"{Name} убит\nПолучено {lard} сала\n";
        }

        public override string MakePhrase()
        {
            string[] phraseArray = { "Грустно:(", "Как же печально:(", "Жалко животинку:(" };
            int index = random.Next(0, 3);
            string phrase = phraseArray[index];
            return $"{phrase}";
        }
    }
}