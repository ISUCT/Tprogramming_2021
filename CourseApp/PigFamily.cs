namespace CourseApp {
    using System;
    using System.Collections.Generic;

    public abstract class PigFamily {
        private int salo;
        private int weight;
        private int age;

        public PigFamily()
        : this("неизвестного животного", 10, 12, 13) {
        }

        public PigFamily(string name, int weight, int salo)
        : this(name, weight, 0, salo) {
        }

        public PigFamily(string name, int weight, int age, int salo) {
            Name = name;
            Salo = salo;
            Age = age;
            Weight = weight;
        }

        public string Name {
            get;
            set;
        }

        public int Weight {
            get {
                return weight;
            }

            set {
                if (value < 0) {
                    weight = 0;
                }
                else {
                    weight = value;
                }
            }
        }

        public int Age {
            get {
                return age;
            }

            set {
                if (value < 0) {
                    age = 0;
                }
                else {
                    age = value;
                }
            }
        }

        public int Salo {
            get {
                return salo;
            }

            set {
                if (value < 0) {
                    salo = 0;
                }
                else {
                    salo = value;
                }
            }
        }

        public override string ToString() {
            if (salo == 0) {
                return $"{Name} не носит в себе сало\n";
            }
            else {
                return $"Из {Name} можно цепануть {Salo} сала\n";
            }
        }

        public abstract string Died();

        public abstract string MakePhrase();
    }
}