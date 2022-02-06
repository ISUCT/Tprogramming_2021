Formula10 f = new Formula10();
double[] res = f.calcA(1.25, 2.75, 0.3, 2.0, 0.95);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(res[i]);
}
double[] x = { 2.2, 3.78, 4.51, 6.58, 1.2 };
double[] ress = f.calcB(x, 2.0, 0.95);
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(ress[i]);
}
public class Formula10
{
    public double Form10(double x, double a, double b)
    {
        double numerator = 1 + Math.Pow(Math.Log10(x/a),2);
        double denumerator = b - Math.Exp(x / a);
        return numerator / denumerator;
    }

    public double[] calcA(double xb, double xe, double dx, double a, double b)
    {
        int len = (int)((xe - xb) / dx);
        double[] res = new double[len];
        int i = 0;
        while (xb < xe)
        {
            res[i] = Form10(xb, a, b);
            i++;
            xb = Math.Round(xb + dx,2);
        }

        return res;
    }

    public double[] calcB(double[] x, double a, double b)
    {
        int len = 5;
        double[] res = new double[len];

        for (int i = 0; i < res.Length; i++)
        {
            res[i] = Form10(x[i], a, b);
        }

        return res;
    }
}