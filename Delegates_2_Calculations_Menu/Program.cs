Console.WriteLine("Let's do this");

MyDelegate del = Add;

Console.WriteLine("Let's compute");
Console.WriteLine("1 for Add");
Console.WriteLine("2 for Sub");
Console.WriteLine("3 for Multi");
Console.WriteLine("4 for Divi");
int choice = Convert.ToInt32(Console.ReadLine());
switch(choice)
{
    case 1:
        del = Add;
        break;
    case 2:
        del = Subtract;
        break;
    case 3:
        del = Multiply;
        break;
    case 4:
        del = Divide;
        break;
}

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
var res=del.Invoke(a,b);
Console.WriteLine(res);

static int Add(int a, int b)
{
    return a + b;
}
static int Subtract(int a, int b)
{
    return a - b;
}
static int Multiply(int a, int b)
{
    return a * b;
}
static int Divide(int a, int b)
{
    return Convert.ToInt32(a / b);
}

public delegate int MyDelegate(int x, int y);


