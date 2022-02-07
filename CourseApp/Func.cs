namespace CourseApp
{
    using System;

    public class Func
    {
        public double Foo(double x)
        {
            if (x <= 0)
            {
                return -1;
            }

            double y;
            const double a = 2.0;
            const double b = 0.95;
            y = (1 + Math.Pow(Math.Log(x / a, 10), 2)) / (b - Math.Pow(Math.E, x / a));
            return y;
        }
    }
}
