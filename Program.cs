namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double a = 1.2;
            const double b = 0.48;
            var funcalc = new Lab1_function_();
            Console.WriteLine("Task A\n");
            funcalc.CalculateTaskA(0.7, 2.2, 0.3, b, a);
            double[] nums = new double[] { 0.25, 0.36, 0.56, 0.94, 1.28 };
            Console.WriteLine("Task B\n");
            funcalc.CalculateTaskB(nums, b, a);
            Console.ReadKey();
        }
    }
}
