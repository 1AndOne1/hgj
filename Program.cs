using System;
using System.Linq.Expressions;

class Calculator
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {

            if (b != 0)
            {
                return a / b;
            }

            else
            {
                throw new DivideByZeroException("Cannot divide by zero!");
            }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = calculator.Sum(a, b);
        int diff = calculator.Subtract(a, b);
        int mult = calculator.Multiply(a, b);
        int quot = calculator.Divide(a, b);

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {diff}");
        Console.WriteLine($"Product: {mult}");
        Console.WriteLine($"Quotient: {quot}");
    }
}