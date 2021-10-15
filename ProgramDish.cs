namespace CourseApp
{
    using System;

    public class DishClass
    {
        private int price;

        public string Name { get; set; }

        public int Weight { get; set; }

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value > 0 & value < 10000)
                {
                    price = value;
                }
            }
        }

        public object ProgramDish(string name, int weight, int price)
        {
            Console.WriteLine("dish constructor called");
            Name = name;
            Weight = weight;
            Price = price;
            return (name, weight, price);
        }
    }
}
