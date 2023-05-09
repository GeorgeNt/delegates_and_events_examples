// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyClass a = new MyClass();
a.LongRunningMethod(FirstCallback);
a.LongRunningMethod(AnotherCallBackMethod);

//I don't care about the name of the method
//FirstCallback - AnotherCallBackMethod

//tight couple

void FirstCallback(int i)
{
    Console.WriteLine(i/1000 + "%");
}

void AnotherCallBackMethod(int i)
{
    Console.WriteLine($"Keep it Up {i}");
}


public class MyClass
{
    public delegate void Callback(int i);
    public void LongRunningMethod(Callback obj)
    {
        for (int i = 0; i<100000; i++)
        {
            //Do Something
            if(i % 1000 == 0)
            {
                Thread.Sleep(50);
                obj.Invoke(i);    
                //also obj.(i);
            }
        }
    }
}



