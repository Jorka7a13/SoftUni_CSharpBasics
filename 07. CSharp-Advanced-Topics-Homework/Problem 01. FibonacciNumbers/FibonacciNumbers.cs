// Define a method Fib(n) that calculates the n-th Fibonacci number
using System;

class FibonacciNumbers
{
    static int Fib(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }

    static void Main()
    {
        int n;
        do 
        {
            Console.Write("Please enter n: ");
        } while(!int.TryParse(Console.ReadLine(), out n));

        Console.WriteLine("Fib(n) = " + Fib(n));
    }
}