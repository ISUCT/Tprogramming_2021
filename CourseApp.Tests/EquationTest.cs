namespace CourseApp.Tests
{
    using Xunit;

    public class EquationTest
    {
        [Fact]
        public void TaskA_NOERR()
        {
            Equation f = new Equation();

            double xn = 1.2;
            double xk = 4.2;
            double dx = 0.6;
            double[] test_res = new double[6] { 0.0249195801363869, 0.0232790179297731, 0.0213859166775433, 0.0195423626784598, 0.0178502973136298, 0.016334146451246 };

            double[] res = f.TaskA(xn, xk, dx);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], test_res[i]);
            }
        }

        [Fact]
        public void TaskB_NOERR()
        {
            Equation f = new Equation();

            double[] test_nums = new double[5] { 1.16, 1.32, 1.47, 1.65, 1.93 };
            double[] test_res = new double[5] { 0.0250047248573638, 0.0246393618709823, 0.0242470198513219, 0.0237322773817728, 0.0228750269630625 };

            double[] res = f.TaskB(test_nums);

            for (int i = 0; i < res.Length; i++)
            {
                Assert.Equal(res[i], test_res[i]);
            }
        }
    }
}