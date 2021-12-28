namespace CourseApp
{
    using System;
    using System.Collections.Generic;
    using Kantaiko.ConsoleFormatting;

    public class TaskRunner
    {
        private readonly Function _function;

        public TaskRunner()
        {
            _function = new Function();
        }

        public List<double> Calculation(double a, double xn, double xk, double dx)
        {
            var listA = new List<double>();
            for (var x = xn; x <= xk; x += dx)
            {
                listA.Add(_function.CalculateFunction(a, x));
            }

            return listA;
        }

        public List<double> Calculation(double a, List<double> xs)
        {
            var listB = new List<double>();
            foreach (var x in xs)
            {
                listB.Add(_function.CalculateFunction(a, x));
            }

            return listB;
        }
    }
}