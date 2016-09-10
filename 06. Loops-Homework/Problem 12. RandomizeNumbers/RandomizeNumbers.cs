// Print the numbers [1n] in random order
using System;

class RandomizeNumbers
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
            array[i] = i + 1;
        }

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            int index = rand.Next(0, n);
            while (array[index] == 0)
            {
                index = rand.Next(0, n); 
            }
            Console.Write(array[index] + " ");
            array[index] = 0;
        }
    }
}