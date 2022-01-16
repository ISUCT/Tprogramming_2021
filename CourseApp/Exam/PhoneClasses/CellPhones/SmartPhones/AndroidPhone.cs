namespace CourseApp.Exam.PhoneClasses.CellPhones.SmartPhones
{
    using System;
    using CourseApp.Exam.Interfaces;

    public class AndroidPhone : SmartPhone, IProduct
    {
        private double _price;

        public AndroidPhone(string name = "NoName", double price = 0, float diagonal = 0)
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
            Console.WriteLine($"AndroidPhone:\n Name: {Name} Price: {Price}$ Diagonal: {Diagonal}$");
        }
    }
}