using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

PrintDelegate printDelegate1 = new PrintDelegate(PrintHello);
printDelegate1.Invoke("Panagiotis");

PrintDelegate printDelegate2 = new PrintDelegate(PrintGoodbye);
printDelegate2("Giannis");

PrintDelegate printDelegate3 = printDelegate1 + printDelegate2;
printDelegate3.Invoke("Giwrgos");


void PrintHello(string message)
{
    Console.WriteLine($"Hello, {message}!");
}

void PrintGoodbye(string message)
{
    Console.WriteLine($"Goodbye, {message}!");
}

delegate void PrintDelegate(string message);
//Orizw ena delegate pou antiproswpeyei ena function to opoio gia na leitourgisei
//xreiazetai ena string, estw message kai epistrefei tipota

//Ti einai to delegate???? It's a reference to a function
//a """variable""" that stores a function
//it's a way to pass a function to function

//void Dele(void Func lala (string message) )
//{
//    Exec this function me opoio message tou petaksw kata to invoke:) :) :)
//}