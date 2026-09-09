using System;
using System.Runtime.InteropServices;
class program
{
    delegate void myDelegete();
    static void Method1()
    {
        Console.WriteLine("Method 1 called");
    }
    static void Method2()
    {
        Console.WriteLine("Method 2 called");

    }
    static void Method3()
    {
        Console.WriteLine("Method 3 called");
    }
    static void Main3()
    {
        myDelegete d1 = Method1;
        Console.WriteLine("Unicast Delegets:");
        d1();
        myDelegete d2 = Method2;
        d2 += Method2;
        d2 += Method3;
        Console.WriteLine("\nMulticast Delegetes");
        d2();
        Console.ReadLine();

    }

   

}