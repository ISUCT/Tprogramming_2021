using System;
namespace CourseApp
{

public class Program
{
public static double Calc(double a, double b, double x)
{
var numerator = a+(Math.Tan(b*x))^3;
var denominator = b +(1/Math.Tan(a+x))^2;
var y = numerator / denominator;
return y;
}
public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
{
var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
int i = 0;
for (var x = xn; x <= xk; x += dx)
{
var y = Calc(a, b, x);
res[i] = (x, y);
i++;
}
return res;
}
public static (double x, double y)[] TaskB(double a, double b, double[] xItems)
{
var res = new(double, double)[xItems.Length];
int i = 0;
foreach (var x in xItems)
{
var y = Calc(a, b, x);
res[i] = (x, y);
i++;
}
return res;
}
public static void Main(string[] args)
{
const double a = 0.1;
const double b = 0.5;
Console.WriteLine($" task A ");
var taskA = TaskA(a, b, 0.15, 1.37, 0.25);
foreach (var item in taskA)
{
var(x, y) = item;
Console.WriteLine($"x={x}, y={y}");
}
Console.WriteLine($" task B");
double[] xItems = { 0.2, 0.3, 0.44, 0.6, 0.56 };
var taskB = TaskB(a, b, xItems);
foreach (var item in taskB)
{
var(x, y) = item;
Console.WriteLine($"x={x}, y={y}");
}
}
}
}