using System;
class Program
{
    delegate double Calculator(double a, double b);
    static double Add(double a, double b)
    {
        return a + b;
    }
    static double Subtract(double a, double b)
    {
        return a - b;
    }
    static double Multiply(double a, double b)
    {
        return a * b;
    }
    static double Divide(double a, double b)
    {
        return a / b; 
    }
    static void Main4()
    {
        Calculator calc;

        calc = Add;
        Console.WriteLine("Addition = " + calc(20, 10));

        calc = Subtract;
        Console.WriteLine("Subtraction = " + calc(20, 10));

        calc = Multiply;
        Console.WriteLine("Multiplication = " + calc(20, 10));

        
        calc = Divide;
        Console.WriteLine("Division = " + calc(20, 10));

        Console.ReadLine();
    }
        


}
