// Exchange bits 3, 4 and 5 with bits 24, 25 and 26 of a given uint
using System;

class BitsExchange
{
    static void ExchangeBits(ref uint number, int firstPosition, int secondPosition)
    {
        uint mask;

        //Get bit values
        mask = 1u << firstPosition;
        uint firstBit = (number & mask) >> firstPosition;
        mask = 1u << secondPosition;
        uint secondBit = (number & mask) >> secondPosition;

        //Change first bit
        if (secondBit == 0)
        {
            number = number & ~(1u << firstPosition);
        }
        else
        {
            mask = 1u << firstPosition;
            number = mask | number;
        }

        // Change second bit
        if (firstBit == 0)
        {
            number = number & ~(1u << secondPosition);
        }
        else
        {
            mask = 1u << secondPosition;
            number = mask | number;
        }
    }

    static void Main()
    {
        Console.Write("Please enter a number: ");
        uint n = uint.Parse(Console.ReadLine());

        ExchangeBits(ref n, 3, 24);
        ExchangeBits(ref n, 4, 25);
        ExchangeBits(ref n, 5, 26);

        Console.WriteLine("The result is: " + n);
    }
}