namespace FunctionTask
{
    using System;

    public class FuncRunner
    {
        public static void Runner(string[] args)
        {
            double xn = 0.08;
            double xk = 1.08;
            double xd = 0.2;
            double[] values = { 0.1, 0.3, 0.4, 0.45, 0.65 };
            Tasks tasksAB = new Tasks();

            double[] taskA = tasksAB.CalculateTask(xn, xk, xd);
            double[] taskB = tasksAB.CalculateTask(values);

            foreach (double x in taskA)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("-----------------------------");
            Console.Title = "DD";
            Console.WriteLine(Console.Title);

            foreach (double x in taskB)
            {
                Console.WriteLine(x);
            }
        }
    }
}