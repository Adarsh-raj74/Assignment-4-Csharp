using System;

class Program2
{
    delegate int AddDelegate(int a, int b);
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main2()
    {
        AddDelegate d = Add;
        int result = d(10, 20);

        Console.WriteLine("Sum = " + result);

        Console.ReadLine();
    }
}
