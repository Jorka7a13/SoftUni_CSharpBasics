// Read a sequence of integers, sort and print them
using System;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            int x;
            do
            {
                Console.Write("Please enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out x));

            array[i] = x;
        }

        Array.Sort<int>(array);
        foreach (int num in array)
        {
            Console.WriteLine(num);
        }
    }
}