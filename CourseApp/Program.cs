using System;
namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a,double x)
        {
           double numenator = Math.Pow(a, x * x - 1) - Math.Log10(x * x - 1) + Math.Pow( x * x - 1, 1 / 3);
            return numenator;
        }
        public static (double x)[] TaskA(double a, double xn, double xk, double dx)
        {
            var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = Calc(a, x);
                res[i] = (x, y);
                i++;
            }
            return res;
        }
        public static (double x, double y)[] TaskB(double a,double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(a, x);
                res[i] = (x, y);
                i++;
            }
            return res;
        }
        public static void Main(string[] args)
        {
            const double a = 2.25;
        
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, 1.2, 2.7, 0.3);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }
            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 1.31, 1.39, 1.44, 1.56, 1.92 };
            var taskB = TaskB(a, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }
        }
    Pistol glock = new Pistol("glock", 9, 7);
            Console.WriteLine(glock.Shot());
            Console.WriteLine(glock.Clip);

    }
}

    
      
