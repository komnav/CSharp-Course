// See https://aka.ms/new-console-template for more information
Console.WriteLine("a?");
var a = double.Parse(Console.ReadLine());
if (a < 1)
{
    Console.WriteLine($"choryaki 1={a}");
}
else if (a > 1 && a < 5)
{
    Console.WriteLine($"choryaki 2={a}");
}
else Console.WriteLine($"chjryaki 3={a}");