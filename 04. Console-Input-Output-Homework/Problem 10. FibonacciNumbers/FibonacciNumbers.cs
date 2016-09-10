// Read a number "n" and print the first "n" members of the Fibonacci sequence
using System;

class FibonacciNumbers
{
    static int Fibonacci(int num)
    {
        if (num == 0)
        {
            return 0;
        } 
        else if(num <= 2)
	    {
            return 1;
	    }
        else
        {
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }

    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
        Console.WriteLine();
    }
}