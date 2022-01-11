namespace CourseApp
{
    using System;

    public class IOSPhone : SmartPhone, IProduct
    {
        private double price;

        public IOSPhone(string name, float diagonal, double price)
        {
            Name = name;
            Price = price;
            Diagonal = diagonal;
        }

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }

        public void Present()
        {
            Console.WriteLine($@"IOSPhone:    Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Diagonal: {Diagonal} Price: {Price}$");
        }
    }
}
