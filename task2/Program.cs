using System;
using System.Linq.Expressions;
using task2;

public static class Program
{
    static void Main(string[] args)
    {
       int month = Convert.ToInt32(Console.ReadLine());
       switch (month)
        {
            case (int)Months.January:
                Console.WriteLine("Yanvar, qis ayidir");
                break;
            case (int)Months.February:
                Console.WriteLine("Fevral, qis ayidir");
                break;
            case (int)Months.March:
                Console.WriteLine("Mart, yaz ayidir");
                break;
            case (int)Months.April:
                Console.WriteLine("Aprel, yaz ayidir");
                break;
            case (int)Months.May:
                Console.WriteLine("May, yaz ayidir");
                break;
            case (int)Months.June:
                Console.WriteLine("Iyun, yay ayidir");
                break;
            case (int)Months.July:
                Console.WriteLine("Iyul, yay ayidir");
                break;
            case (int)Months.August:
                Console.WriteLine("Avqust, yay ayidir");
                break;
            case (int)Months.September:
                Console.WriteLine("Sentyabr, payiz ayidir");
                break;
            case (int)Months.October:
                Console.WriteLine("Oktyabr, payiz ayidir");
                break;
            case (int)Months.November:
                Console.WriteLine("Noyabr, payiz ayidir");
                break;
            case (int)Months.December:
                Console.WriteLine("Dekabr, qis ayidir");
                break;
        } 

    }
}