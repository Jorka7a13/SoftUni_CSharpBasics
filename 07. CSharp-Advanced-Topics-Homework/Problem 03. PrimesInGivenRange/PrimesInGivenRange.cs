// Define a method that calculates all prime numbers in given range and returns them as list of integers
using System;
using System.Collections.Generic;

class PrimesInGivenRange
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

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> resultList = new List<int>();

        for (int i = startNum; i <= endNum; i++)
        {
            if (IsPrime(i))
            {
                resultList.Add(i);
            }
        }

        return resultList;
    }

    static void Main()
    {
        int startNum, endNum;
        do
        {
            Console.Write("Please enter starting number: ");
        } while (!int.TryParse(Console.ReadLine(), out startNum));
        do
        {
            Console.Write("Please enter ending number: ");
        } while (!int.TryParse(Console.ReadLine(), out endNum));

        List<int> result = FindPrimesInRange(startNum, endNum);

        if (result.Count != 0)
        {
            for (int i = 0; i < result.Count; i++)
            {
                if (i < result.Count - 1)
                {
                    Console.Write(result[i] + ", ");
                }
                else
                {
                    Console.WriteLine(result[i]);
                }
            }
        }
        else
	    {
            Console.WriteLine("(empty list)");
	    }
    }
}