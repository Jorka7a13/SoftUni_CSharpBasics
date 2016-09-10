// Check if a given number's third digit from right-to-left is 7
using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Please enter number: ");
        int num = int.Parse(Console.ReadLine());

        num /= 100;

        if (num % 10 == 7)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}