using System;
class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        Func<int, int, int> operation;
        operation = Add;

        Console.WriteLine("Addition: " + operation(10, 5));

        operation = Multiply;

        Console.WriteLine("Multiplication: " + operation(10, 5));

        operation = Subtract;

        Console.WriteLine("Subtraction: " + operation(10, 5));

        Func<int, int, int> multiOperation;

        multiOperation = Add;
        multiOperation += Multiply;
        multiOperation += Subtract;

        Console.WriteLine("\nMulticast Func Delegate:");

        Delegate[] methods = multiOperation.GetInvocationList();

        foreach (Delegate method in methods)
        {
            int result = (int)method.DynamicInvoke(10, 5);

            Console.WriteLine(method.Method.Name + " = " + result);
        }
    }
}