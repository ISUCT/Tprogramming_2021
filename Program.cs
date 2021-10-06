namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            const double b = 1.1;
            const double a = 2.0;
            var functionCalculator = new FunctionCalculator();
            Console.WriteLine("Calculating task A:\n");

            foreach (double num in functionCalculator.CalculateTaskA(a, 0.08, 1.08, 0.2, b))
            {
                Console.WriteLine(num);
            }

            double[] nums = new double[] { 0.1, 0.3, 0.4, 0.45, 0.65 };
            Console.WriteLine("\nCalculating task B:\n");
            foreach (double num in functionCalculator.CalculateTaskB(a, nums, b))
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}