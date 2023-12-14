/*bool a = Boolean.Parse(Console.ReadLine());
bool b = Boolean.Parse(Console.ReadLine());
bool c = a ^ b;
Console.WriteLine(c);*/

int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
var summ = summa(array, true);
int[] array2 = [12, 13, 14, 15, 16];
summ += summa(array2, false);
Console.WriteLine(summ);
static int summa(int[] array, bool juft)
{
    int summ = 0;
    foreach (var item in array)
    {
        if (juft)
        {
            if (item % 2 == 0)
            {
                summ += item;
            }
        }
        else
        {
            if (item % 2 != 0)
                summ += item;
        }
    }

    return summ;

}


int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
int summ = 0;
foreach (var item in array)
{
    if (item % 2 != 0)
        summ += item;

}
Console.WriteLine(summ);