// Check if a given integer is odd or even

using System;

class OddOrEvenIntegers
{
    static void Main()
    {

        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}