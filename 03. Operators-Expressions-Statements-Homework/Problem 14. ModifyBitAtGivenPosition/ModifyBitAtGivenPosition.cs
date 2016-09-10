// Bitwise modify "n" to hold the value "v" at the position "p" 
using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter a value: ");
        int v = int.Parse(Console.ReadLine());

        int mask = 1 << p;

        if (v == 1)
        {
            n |= mask;
        }
        else
        {
            n &= ~mask;
        }

        Console.WriteLine("The result is: " + n);
    }
}