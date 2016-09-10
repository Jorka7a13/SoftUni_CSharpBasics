// Calculate the n-th Catalan number by given n 
using System;
using System.Numerics;

class CatalanNumbers
{

    static double CalculateFactorial(int num)
    {
        double sum = 1;
        for (int i = 1; i <= num; i++)
        {
            sum *= i;
        }
        return sum;
    }

    static void Main()
    {
        int n;
        BigInteger result;

        do
        {
            do
            {
                Console.Write("Please enter n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
        } while(n <= 1 || n >= 100);

        result = (BigInteger)CalculateFactorial(2 * n) / (BigInteger)(CalculateFactorial(n + 1) * CalculateFactorial(n));
        Console.WriteLine("The result is: " + result);
    }
}