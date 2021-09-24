namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double b = 4.2;
            const double a = 7.2;
            var funcalc = new Функция();
            Console.WriteLine("Calculating task A\n");
            funcalc.CalculateTaskA(1.81, 5.31, 0.7, a, b);
            double[] nums = new double[] { 2.4, 2.8, 3.9, 4.7, 3.16 };
            Console.WriteLine("Calculating task B\n");
            funcalc.CalculateTaskB(nums, a, b);
            Console.ReadKey();
        }
    }
}
