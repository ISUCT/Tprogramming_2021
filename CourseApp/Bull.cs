namespace CourseApp
{
    using System;
    /* using System.Collections.Generic;*/

    public class Bull : Animals
    {
        private Random random = new Random();

        public Bull()
        : base()
        {
        }

        public Bull(string name, int weight)
        : base(name, weight)
        {
        }

        public Bull(string name, int weight, int lard)
        : base(name, weight, lard)
        {
        }

        public Bull(string name, int weight, int age, int lard)
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