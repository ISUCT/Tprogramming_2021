namespace CourseApp
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var a = 2.0;
            var xNach = 1.2;
            var xKon = 4.2;
            var xDel = 0.6;
            double[] xArr = { 1.16, 1.32, 1.47, 1.65, 1.93 };
            var calculator = new Calculator();
            calculator.ConsoleOut(a, xArr, xDel, xNach, xKon);
            Console.ReadLine();
        }
    }
}
