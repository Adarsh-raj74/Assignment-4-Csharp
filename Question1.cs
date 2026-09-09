using System;

class Program1
{
    static void Display(string message)
    {
        Console.WriteLine(message);
    }

    delegate void MyDelegate(string message);

    static void Main1()
    {
        MyDelegate d = Display;
        d("Hello from Delegate!");

        Console.ReadLine();
    }
}