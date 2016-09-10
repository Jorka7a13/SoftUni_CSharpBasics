// Does the bit at position "p" in given integer "n" have a value of 1
using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a bit position: ");
        int p = int.Parse(Console.ReadLine());

        int result = n & (1 << p);
        if (result >> p == 1)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}