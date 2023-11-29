// See https://aka.ms/new-console-template for more information
Console.WriteLine("a?");
var a = double.Parse(Console.ReadLine());
Console.WriteLine("b?");
var b = double.Parse(Console.ReadLine());
Console.WriteLine("c?");
var c = double.Parse(Console.ReadLine());
double kalon = a;
double xurd = a;
if (b>kalon)
    kalon=b;
if (b < xurd)
    b = xurd;
if (c>kalon) 
    kalon=c;
if (c < xurd) 
    xurd=c;
Console.WriteLine($"kalontarin:{kalon}xurdtarin:{xurd}");