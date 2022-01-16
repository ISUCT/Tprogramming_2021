namespace CourseApp.Exam.PhoneClasses
{
    using System;
    using CourseApp.Exam.Interfaces;

    public class LandLinePhone : Phone, IProduct
    {
        private double _price;

        public LandLinePhone(string name = "NoName", double price = 0)
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
            Console.WriteLine($"LandLinePhone:\n Name: {Name} Price: {Price}$");
        }
    }
}