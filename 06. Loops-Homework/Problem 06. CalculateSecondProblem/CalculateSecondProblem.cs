// Calculate N! / K!
using System;

class CalculateSecondProblem
{
    static void Main()
    {
        int n, k;
        double sumN = 1, sumK = 1;
        do
        {
            do
            {
                Console.Write("Please enter n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            do
            {
                Console.Write("Please enter k: ");
            } while (!int.TryParse(Console.ReadLine(), out k));
        } while(1 >= k && k >= n && n >= 100);

        for (int i = 1, j = 1; i <= n; i++)
        {
            sumN *= i;
            if (j <= k)
            {
                sumK *= j;
                j++;
            }
        }

        Console.WriteLine("The result is: " + (sumN / sumK));
    }
}