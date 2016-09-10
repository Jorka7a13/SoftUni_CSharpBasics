// Enter n numbers, calculate and prints their sum
using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Please enter a number: ");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is " + sum);
    }
}