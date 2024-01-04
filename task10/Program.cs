//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//MyDelegate linkToMethod1 = Method1;
//linkToMethod1("#1");
//MyDelegate2 link = jam;
//int res=link (1,2);
//link = zarb;
//int res2 = link (1,2);


var jamLambda = static (int r1, int r2) => r1 + r2;



static void Method1(in string argument)
{
    Console.WriteLine($"Method 1 is running. Argument is {argument}");
    argument="";//когда мы используем in параметр становится readonly.И его невозможно изминить.
}
static int jam(int r1, int r2)
{
    int result = r1 + r2;
    return result;
}

static int zarb(int r1, int r2)
{
    int result = r1 * r2;
    return result;
}

static double taqsim(int r1, int r2)
{
    if (r2 != 0)
    {
        double result = r1 / r2;
        return result;
    }
    else
    {
        return 0;
    }
}

public delegate void MyDelegate(string arg);
public delegate int MyDelegate2(int r1, int r2);