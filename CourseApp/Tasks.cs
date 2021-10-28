namespace CourseApp.FunctionTask
{
    public class Tasks
    {
        private Function _function = new Function();

        public double[] CalculateTask(double xn, double xk, double xd)
        {
            int k = 0;
            double[] taskA = new double[6];
            for (double i = xn; i <= xk; i += xd)
            {
                taskA[k++] = _function.Calculate(i);
            }

            return taskA;
        }

        public double[] CalculateTask(double[] values)
        {
            double[] taskB = new double[5];
            int k = 0;
            foreach (double i in values)
            {
                taskB[k++] = _function.Calculate(i);
            }

            return taskB;
        }
    }
}