// Extract from given integer "n" the value of given bit at index "p"
using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a bit position: ");
        int p = int.Parse(Console.ReadLine());

        int result = n & (1 << p);
        Console.WriteLine("The bit at position #{0} is: {1}", p, result >> p);
    }
}