using System;

class Program7
{
    delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Method1 is executed");
    }

    static void Method2()
    {
        Console.WriteLine("Method2 is executed");
    }

    static void Method3()
    {
        Console.WriteLine("Method3 is executed");
    }

    static void Main()
    {
        MyDelegate d = Method1;
        d += Method2;
        d += Method3;

        Console.WriteLine("Methods stored in delegate:");

        foreach (Delegate method in d.GetInvocationList())
        {
            Console.WriteLine("Method Name: " + method.Method.Name);
            method.DynamicInvoke();
        }

        Console.ReadLine();
    }
}