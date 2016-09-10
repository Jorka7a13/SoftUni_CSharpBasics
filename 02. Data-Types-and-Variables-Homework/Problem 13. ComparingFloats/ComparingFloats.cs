// Write a program that safely compares floating-point numbers with precision eps = 0.000001.

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = Double.Parse(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        double b = Double.Parse(Console.ReadLine());

        double eps = 0.000001;

        if (a > b)
        {
            if (a - b > eps)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
        else 
        {
            if (b - a > eps)
	        {
		        Console.WriteLine("False");
	        }    
            else
	        {
                Console.WriteLine("True");   
	        }
        }
    }
}
