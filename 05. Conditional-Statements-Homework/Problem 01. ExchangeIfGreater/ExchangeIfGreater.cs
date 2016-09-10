// Take two integer variables and exchange their values if the first one is greater
using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b; 
        }

        Console.WriteLine(a + " " + b);
    }
}