// Print three numbers sorted in descending order. Use nested if statements.
using System;

class SortThreeNumbersNestedIfs
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a > b)
        {
            if (a > c)
            {
                Console.Write(a);
                if (b > c)
                {
                    Console.Write(" " + b + " " + c);
                }
                else
                {
                    Console.Write(" " + c + " " + b);
                }
            }
            else
            {
                Console.Write(c + " " + a + " " + b);
            }
        }
        else // b > a
        {
            if (a > c)
            {
                Console.Write(b + " " + a + " " + c);
            }
            else 
            {
                if (b > c)
                {
                    Console.Write(b + " " + c + " " + a);
                }
                else
                {
                    Console.Write(c + " " + b + " " + a);
                }
            }
        }
        Console.WriteLine();
    }
}