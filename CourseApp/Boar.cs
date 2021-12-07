namespace CourseApp
{
    using System;
    using System.Collections.Generic;

    public class Boar : Animals
    {
        private Random random = new Random();

        public Boar()
        : base()
        {
        }

        public Boar(string name, int weight)
        : base(name, weight)
        {
        }

        public Boar(string name, int weight, int lard)
        : base(name, weight, lard)
        {
        }

        public Boar(string name, int weight, int age, int lard)
        : base(name, weight, age, lard)
        {
        }

        public override string Died()
        {
            int lard = Lard;
            Lard = 0;
            return $"{Name} убит\nПолучено {lard} сала\n";
        }

        public override string MakePhrase(string[] phraseArray)
        {
            int index = random.Next(0, 3);
            string phrase = phraseArray[index];
            return $"{phrase}";
        }
    }
}