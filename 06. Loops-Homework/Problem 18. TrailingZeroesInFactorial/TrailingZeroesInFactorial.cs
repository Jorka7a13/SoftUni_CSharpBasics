// Calculate how many zeroes the factorial of a given number has at its end
using System;

class TrailingZeroesInFactorial
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        int result = 0, i;

        for (i = 5; i < n / 5; i *= 5)
        {
            result += n / i;
        }

        result += n / i;
        Console.WriteLine("The result is: " + result);
    }
}