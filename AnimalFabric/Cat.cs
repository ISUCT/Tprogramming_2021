using AnimalFabric.abstracts;

namespace AnimalFabric
{
    public class Cat : Animal
    {
        public Cat(string FurColor, byte TailLength, byte EyeColor, byte AdditionalEyeColor, byte LifesCount, sbyte AgilityCount, byte Age, float Weight)
        {
            this.FurColor = FurColor;
            this.TailLength = TailLength;
            this.EyeColor = EyeColor;
            this.AdditionalEyeColor = AdditionalEyeColor;
            this.Age = Age;
            this.LifesCount = LifesCount;
            this.AgilityCount = AgilityCount;
            this.Weight = Weight;
        }


        // Когти
        public bool IsNailsOpen { get; set; }

        // Стерилизация
        public bool IsSterilizated { get; set; }

        // Шерсть
        public bool IsFur { get; set; }

        public string FurColor { get; set; }

        // Хвост
        public bool IsTail { get; set; }

        // 1 - Короткий
        // 2 - Средний
        // 3 - Длинный
        public byte TailLength { get; set; }


        // Разнозветные глаза
        public bool IsDifferentEyeColor { get; set; }
        // Правый глаз
        public byte AdditionalEyeColor { get; set; }

        // Действие - атака
        public override void Attack()
        {
            Console.WriteLine("I'm cat attack");
        }

        public override byte GetFoodCount()
        {
            throw new NotImplementedException();
        }

        public Mouse Hunt()
        {
            throw new NotImplementedException();
        }
    }
}
