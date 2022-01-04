namespace CourseApp {
    using System;
    using System.Collections.Generic;

    public class Calculation {
        private Function glavFunc;

        public Calculation(Function function) {
            glavFunc = function;
        }

        public List<double> CalculationTask(double a, double b, double xs, double xe, double dx) {
            var peperA = new List<double>();
            for (double x = xs; x <= xe; x += dx) {
                peperA.Add(glavFunc.CalculateFunction(a, b, x));
            }

            return peperA;
        }

        public List<double> CalculationTask(double a, double b, List<double> peperTaskB) {
            var peperB = new List<double>();
            foreach (var x in peperTaskB) {
                peperB.Add(glavFunc.CalculateFunction(a, b, x));
            }

            return peperB;
        }
    }
} 