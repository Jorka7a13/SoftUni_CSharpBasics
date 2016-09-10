// Enter 5 numbers given in a single line, calculate and print their sum
using System;

class SumFiveNumbers
{
    static void Main()
    {
        Console.Write("Please enter five numbers: ");
        string[] arr = Console.ReadLine().Split(' ');

        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += double.Parse(arr[i]); 
        }

        Console.WriteLine("Their sum is " + sum);
    }
}