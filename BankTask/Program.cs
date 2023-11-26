Console.WriteLine("Kolichestvo summ?");
double summ = double.Parse(Console.ReadLine());
Console.WriteLine("Mokh?");
int mokh = int.Parse(Console.ReadLine());
double result = summ;
for (int i = 1; i <= mokh; i++)
{
    result *= 1.07;
    Console.WriteLine($"mokhi={i}-{Math.Round(result,2)}");
}
Console.WriteLine($"foida={Math.Round(result - summ,2)}");

