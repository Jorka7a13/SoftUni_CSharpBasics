// Define a method IsPrime(n) that check whether a given integer number n is prime
using System;

class PrimeChecker
{
    static bool IsPrime(long n)
    {
        if (n > 1)
	    {
            if (n < 10)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                    return true;
            }

            // If n is even it is not prime
            if (n % 10 == 0 || n % 10 == 2 || n % 10 == 4 || n % 10 == 6 || n % 10 == 8) 
            {
                return false;
            }
            else
            {
                for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
        // If n is less than 1
        else
        {
            return false;
        }
    }

    static void Main()
    {
        long n;
        do 
        {
            Console.Write("Please enter n: ");
        } while(!long.TryParse(Console.ReadLine(), out n));

        Console.WriteLine(IsPrime(n));
    }
}