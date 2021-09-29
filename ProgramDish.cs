namespace CourseApp1
{
    using System;

    public class ProgramDish
    {
        private int price;

        public ProgramDish() : this("Maffin", 100, 150)
        {
            Console.WriteLine("dish constructor without params");
        }
        public ProgramDish(string name, int weight, int price)
        {
            Console.WriteLine("dish constructor called");
            Name = name;
            Weight = weight;
            Price = price;
        }

        public string Name { get; set; }

        public int Weight;

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value > 0 & value < 1000)
                {
                    price = value;
                }
            }
        }
    }
}