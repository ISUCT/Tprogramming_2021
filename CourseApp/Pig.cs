namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Pig : PigFamily
    {
        private Random random = new Random();

        public Pig()
        : base()
        {
        }

        public Pig(string name, int weight, int lard)
        : base(name, weight, lard)
        {
        }

        public override string Died()
        {
            int lard = Lard;
            return $"{Name} зарезана\nПолучено {lard} сала\n";
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