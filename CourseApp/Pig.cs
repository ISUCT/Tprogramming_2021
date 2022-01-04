namespace CourseApp {
    using System;
    using System.Collections.Generic;

    public class Pig : PigFamily {
        private Random random = new Random();

        public Pig()
        : base() {
        }

        public Pig(string name, int weight, int salo)
        : base(name, weight, salo) {
        }

        public override string Died() {
            int salo = Salo;
            return $"{Name} заколота\nПолучено {salo} сала\n";
        }

        public override string MakePhrase() {
            string[] phraseArray = { "Жалко свинку", "Бедная свинка", "Печально" };
            int index = random.Next(0, 3);
            string phrase = phraseArray[index];
            return $"{phrase}";
        }
    }
}