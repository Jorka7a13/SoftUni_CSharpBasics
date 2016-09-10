// Read 3 real numbers from the console and print their sum
using System;

class SumThreeNumbers
{
    static void Main()
    {
        double sum = 0;

        Console.Write("Please enter the first number: ");
        sum += double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        sum += double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        sum += double.Parse(Console.ReadLine());

        Console.WriteLine("The sum is " + sum);
    }
}