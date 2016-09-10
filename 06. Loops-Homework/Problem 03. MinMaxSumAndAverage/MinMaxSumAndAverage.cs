// Print the minimal number, the maximal number, the sum and the average of n numbers
using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter n: ");
        }
        while (!int.TryParse(Console.ReadLine(), out n));

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            do 
            {
                Console.Write("Please enter a number: ");
            } while(!int.TryParse(Console.ReadLine(), out array[i]));
        }

        int min = array[0], max = array[0], sum = 0;

        foreach (int num in array)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }

            sum += num;
        }

        Console.WriteLine("The min is: " + min);
        Console.WriteLine("The max is: " + max);
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: {0:F2}", (double)sum / n);
    }
}