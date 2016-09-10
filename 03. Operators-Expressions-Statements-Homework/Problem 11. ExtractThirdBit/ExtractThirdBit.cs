// Find the value of the third bit of a given unsigned integer
using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        uint result = n & 8;
        Console.WriteLine("Bit #3 is: " + (result >> 3));
    }
}