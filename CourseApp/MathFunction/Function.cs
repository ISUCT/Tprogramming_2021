namespace CourseApp
{
    using static System.Math;

    public class Function
    {
        public double CalculateFunction(double a, double x)
        {
            return Pow(a, Pow(x, 2.0) - 1.0) - Log10(Pow(x, 2.0) - 1.0) - Pow(Pow(x, 2.0) - 1.0, 1.0 / 3.0);
        }
    }
}