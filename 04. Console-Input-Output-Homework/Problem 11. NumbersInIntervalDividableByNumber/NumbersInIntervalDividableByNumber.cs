// Read two positive ints and print how many numbers exist between them such that the reminder of the division by 5 is 0
using System;

class NumbersInIntervalDividableByNumber
{
    static void Main()
    {
        int start;
        int end;
        int sum = 0;

        do
        {
            Console.Write("Please enter the starting number: ");
            start = int.Parse(Console.ReadLine());
        } while (start <= 0);

        do
        {
            Console.Write("Please enter the ending number: ");
            end = int.Parse(Console.ReadLine());
        } while (end <= 0);

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                sum++;
            }
        }

        Console.WriteLine("p = " + sum);
    }
}