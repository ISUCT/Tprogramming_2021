namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var eshop = new EShop("Mobile");
            eshop.Present();
            Console.ReadLine();
        }
    }
}
