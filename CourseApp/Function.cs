namespace CourseApp.FunctionTask
{
    using static System.Math;

    public class Function
    {
        private double a = 2.0;
        private double b = 1.1;

        public double Calculate(double x)
        {
            return (Log(Abs(Sqrt(b) - Sqrt(x))) / Log(a)) / Pow(Abs(Sqrt(x) - Sqrt(a)), 1 / 5.0);
        }
    }
}