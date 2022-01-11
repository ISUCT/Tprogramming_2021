namespace CourseApp
{
    using System;

    public class BabushkaPhone : CellPhone, IProduct
    {
        private double price;

        public BabushkaPhone(string name, double price)
        {
            Name = name;
            Price = price;
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
                    price = value;
                }
            }
        }

        public void Present()
        {
            Console.WriteLine($@"BabushkaPhone:    Name: {(string.IsNullOrEmpty(Name) ? "none" : Name)} Price: {Price}$");
        }
    }
}
