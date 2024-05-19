using System;
using task1;

public static class Program
{
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(10,5);
        Console.WriteLine( calculator.CalculateDivision());
        Console.WriteLine(calculator.CalculateSubstraction());
        Console.WriteLine(calculator.CalculateSum());
        Console.WriteLine(calculator.CalcutateMultipication());

    }
}