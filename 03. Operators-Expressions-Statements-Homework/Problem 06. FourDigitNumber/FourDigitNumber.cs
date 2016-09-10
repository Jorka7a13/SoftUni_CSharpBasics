// The program takes as input a four-digit number and performs calculations with it
using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a four-digit number: ");
        int num = int.Parse(Console.ReadLine());
        int a, b, c, d;

        d = num % 10;
        num /= 10;
        c = num % 10;
        num /= 10;
        b = num % 10;
        num /= 10;
        a = num;

        Console.WriteLine("The sum is: " + (a + b + c + d));

        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);

        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);

        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}