namespace CourseApp
{
    using System;
    /*using System.Collections.Generic;*/

    public class Pig : Animals
    {
        private Random random = new Random();

        public Pig()
        : base()
        {
        }

        public Pig(string name, int weight)
        : base(name, weight)
        {
        }

        public Pig(string name, int weight, int lard)
        : base(name, weight, lard)
        {
        }

        public Pig(string name, int weight, int age, int lard)
        : base(name, weight, age, lard)
        {
        }

        public void AddLard(int lard)
        {
            Lard += lard;
        }

        public override string Died()
        {
            int lard = Lard;
            Lard = 0;
            return $"{Name} зарезана\nПолучено {lard} сала\n";
        }

        public override string MakePhrase(string[] phraseArray)
        {
            int index = random.Next(0, 3);
            string phrase = phraseArray[index];
            return $"{phrase}";
        }
    }
}
