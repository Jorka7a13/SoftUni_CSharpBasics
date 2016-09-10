// Can a given number be divided by 7 and 5 at the same time
using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 7 == 0 && n % 5 == 0 && n != 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}