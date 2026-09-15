using System;

class Program
{
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsPositive(int number)
    {
        return number > 0;
    }

    static bool IsGreaterThan100(int number)
    {
        return number > 100;
    }

    static void Main()
    {
        int number = 120;

        Predicate<int> check;

        check = IsEven;
        Console.WriteLine("Is Even: " + check(number));

        check = IsPositive;
        Console.WriteLine("Is Positive: " + check(number));

        check = IsGreaterThan100;
        Console.WriteLine("Greater Than 100: " + check(number));

        Predicate<int> multiCheck;

        multiCheck = IsEven;
        multiCheck += IsPositive;
        multiCheck += IsGreaterThan100;

        Console.WriteLine("\nMulticast Predicate:");

        Delegate[] methods = multiCheck.GetInvocationList();

        foreach (Delegate method in methods)
        {
            bool result = (bool)method.DynamicInvoke(number);

            Console.WriteLine(method.Method.Name + " = " + result);
        }
    }
}