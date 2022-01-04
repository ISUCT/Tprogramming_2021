namespace CourseApp {
    using System;
    using System.Collections.Generic;

    public class Warthog : PigFamily {
        private Random random = new Random();

        public Warthog()
        : base() {
        }

        public Warthog(string name, int weight, int age, int salo)
        : base(name, weight, age, salo) {
        }

        public override string Died() {
            int salo = Salo;
            return $"{Name} убит\nПолучено {salo} сала\n";
        }

        public override string MakePhrase() {
            string[] phraseArray = { "Жалко свинку", "Бедная свинка", "Печально" };
            int index = random.Next(0, 3);
            string phrase = phraseArray[index];
            return $"{phrase}";
        }
    }
}