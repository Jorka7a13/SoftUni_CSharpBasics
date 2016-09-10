// Calculate the greatest common divisor of two integers
using System;

class CalculateGCD
{

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b);
        }
    }

    static void Main()
    {
        int a, b;
        do
        {
            Console.Write("Please enter a: ");
        } while (!int.TryParse(Console.ReadLine(), out a));
        do
        {
            Console.Write("Please enter b: ");
        } while (!int.TryParse(Console.ReadLine(), out b));

        Console.WriteLine("The GCD is " + GCD(a, b));
    }
}