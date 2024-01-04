// See https://aka.ms/new-console-template for more information
Console.WriteLine("n=");
var n=int.Parse(Console.ReadLine());
int fk2 = 0;
int fk1 = 1;
Console.WriteLine("f(1)=1");
//if (n != 1)
//{
//    Console.WriteLine("f(2)=1");
//}
for (int i = 2; i <= n; i++)
{     
    int fnext = fk2 + fk1;
    Console.WriteLine($"f({i})={fnext}");
    fk2 = fk1;
    fk1 = fnext;
}
