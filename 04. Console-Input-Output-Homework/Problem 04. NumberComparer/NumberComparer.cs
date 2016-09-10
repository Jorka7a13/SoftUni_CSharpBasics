// Read two numbers from the console and print the greater of them 
using System;

class NumberComparer
{
    static void Main()
    {

        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
       
        Console.WriteLine((a > b) ? a + " is bigger" : b + " is bigger");
    }
}