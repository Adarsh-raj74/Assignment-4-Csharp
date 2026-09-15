using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Hello from DisplayMessage()");
    }
    static void ShowMessage()
    {
        Console.WriteLine("Hello from ShowMessage()");
    }

    static void Main()
    {
        Action action1;

        action1 = DisplayMessage;

        Console.WriteLine("Unicast Action Delegate:");
        action1();

        Action action2;

        action2 = DisplayMessage;
        action2 += ShowMessage;

        Console.WriteLine("\nMulticast Action Delegate:");
        action2();
    }
}