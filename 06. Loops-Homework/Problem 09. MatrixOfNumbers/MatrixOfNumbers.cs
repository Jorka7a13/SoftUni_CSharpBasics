// Print a matrix 
using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write((j + i) + " ");
            }
            Console.WriteLine();
        }
    }
}