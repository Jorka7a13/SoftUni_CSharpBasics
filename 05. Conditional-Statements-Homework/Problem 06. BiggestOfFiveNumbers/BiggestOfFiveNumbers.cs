// Find the biggest of five numbers by using only five if statements
using System;

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Please enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b);
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine(c);
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine(d);
        }
        else if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(e);
        }
    } 
}