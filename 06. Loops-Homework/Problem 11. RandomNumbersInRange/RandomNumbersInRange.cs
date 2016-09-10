// Print n random numbers in a given range
using System;

class RandomNumbersInRange
{
    static void Main()
    {
        int n, min, max;
        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        do
        {
            do
            {
                Console.Write("Please enter min: ");
            } while (!int.TryParse(Console.ReadLine(), out min));
            do
            {
                Console.Write("Please enter max: ");
            } while (!int.TryParse(Console.ReadLine(), out max));
        } while (min > max);

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write(rnd.Next(min, max + 1) + " ");
        }
        Console.WriteLine();
    }
}