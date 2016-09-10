// Exchange bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given uint
using System;

class BitExchangeAdvanced
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
        Console.Write("Please enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Please enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());

        if (p + k > 31 || q + k > 31)
        {
            Console.WriteLine("out of range");
            return;
        }

        if (p < q)
        {
            if (p + k > q)
            {
                Console.WriteLine("overlapping");
                return;
            }
        }
        else
        {
            if (q + k > p)
            {
                Console.WriteLine("overlapping");
                return;
            }
        }
        

        for (int i = p, j = q; i < p + k; i++, j++)
        {
            ExchangeBits(ref n, i, j);
        }

        Console.WriteLine("The result is: " + n);
    }
}