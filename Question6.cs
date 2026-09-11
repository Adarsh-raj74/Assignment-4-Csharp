using System;

class SalaryCalculator
{
    public static double BasicSalary(double basic)
    {
        return basic;
    }
    public static double HRA(double basic)
    {
        return basic * 0.20;
    }

    public static double DA(double basic)
    {
        return basic * 0.10;
    }

    public static double Bonus(double basic)
    {
        return basic * 0.15;
    }
}

class Program
{
   
    public delegate double SalaryDelegate(double basic);

    static void Main(string[] args)
    {
        Console.Write("Enter Basic Salary: ");
        double basic = Convert.ToDouble(Console.ReadLine());

        SalaryDelegate salary = SalaryCalculator.BasicSalary;
        salary += SalaryCalculator.HRA;
        salary += SalaryCalculator.DA;
        salary += SalaryCalculator.Bonus;

        Console.WriteLine("\nSalary Components:");

        foreach (SalaryDelegate method in salary.GetInvocationList())
        {
            double result = method(basic);

            Console.WriteLine(method.Method.Name + " = " + result);
        }

        Console.ReadLine();
    }
}