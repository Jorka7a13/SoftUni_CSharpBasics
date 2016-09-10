// Print all the numbers from 1 to n not divisible by 3 and 7
using System;

class NotDivisibleNumbers
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.Write(i);
                if (i < n)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
    }
}