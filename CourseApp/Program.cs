namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main()
        {
            const double b = 2.5;
            var functionCalculator = new FunctionCalculator();
            Console.WriteLine("Calculating task A:\n");
            var taskA = functionCalculator.CalculateTaskA(1.28, 3.28, 0.4, b);
            foreach (double num in taskA)
            {
                Console.WriteLine(num);
            }

            double[] nums = new double[] { 1.1, 2.4, 3.6, 1.7, 3.9 };
            Console.WriteLine("\nCalculating task B:\n");
            foreach (double num in functionCalculator.CalculateTaskB(nums, b))
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}