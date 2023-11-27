// See https://aka.ms/new-console-template for more information
Console.WriteLine("a=");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("b=");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("c=");
double c = double.Parse(Console.ReadLine());
var d = (b * b) - (4 * a * c);
if (d > 0)
{
    double x1, x2;

    x1 = (-b - Math.Sqrt(d)) / 2 * a;
    x2 = (-b + Math.Sqrt(d)) / 2 * a;
    Console.WriteLine($"x1 = {x1} x2 = {x2}");
}
else if (d == 0)
{
    double x;
    x = -b / 2 * a;
    Console.WriteLine($"x={x}");
}
else
{

    Console.WriteLine("resha nest!!");
}

