namespace CourseApp.Exam.PhoneClasses.CellPhones
{
    using System;
    using CourseApp.Exam.Interfaces;

    public class BabushkaPhone : CellPhone, IProduct
    {
        private double _price;

        public BabushkaPhone(string name = "NoName", double price = 0)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    _price = 0;
                }
            }
        }

        public void Present()
        {
            Console.WriteLine($"BabushkaPhone:\n Name: {Name} Price: {Price}$");
        }
    }
}