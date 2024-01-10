// See https://aka.ms/new-console-template for more information
//Console.WriteLine("X kg?");
//var X_kg=double.Parse(Console.ReadLine());
//Console.WriteLine("A sm?");
//var A_sm = double.Parse(Console.ReadLine());
//Console.WriteLine($"{X_kg} Kelogram= {A_sm} Somon");
//double a = 1 * A_sm;
//Console.WriteLine("Y kg?");
//var y=double.Parse(Console.ReadLine());
//double y_A_sm=y*A_sm;
//Console.WriteLine(y_A_sm);



Console.WriteLine("X kg?");
var X_kg = double.Parse(Console.ReadLine());
Console.WriteLine("A sm?");
var A_sm = double.Parse(Console.ReadLine());
Console.WriteLine("Y kg?");
var Y_kg = double.Parse(Console.ReadLine());
Console.WriteLine("B sm?");
var B_sm = double.Parse(Console.ReadLine());
double a = 1 * A_sm;
Console.WriteLine($"{X_kg} Kelogram shakalod= {A_sm} Somon");
double b = 1 * B_sm;
Console.WriteLine($"{Y_kg} Kelogram irisok= {B_sm} Somon");
double x = A_sm - B_sm;
if (x < 0)
{
    double z= B_sm - A_sm;
    Console.WriteLine($"{z}somon qimmat irisok az shakalod");
}
else
    Console.WriteLine($"{x}somon qimmat shakalod az irisok");