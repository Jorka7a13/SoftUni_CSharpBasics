// Print all the numbers from 1 to n
using System;

class NumbersFromOneToN
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
            Console.Write(i);
            if (i < n)
            {
                Console.Write(" ");
            }
        }            
        Console.WriteLine();
    }
}