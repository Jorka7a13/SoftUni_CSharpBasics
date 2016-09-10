// Calculate N! / (K! * (N-K)!)
using System;
using System.Numerics;

class CalculateThirdProblem
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
        int n, k;
        BigInteger result;

        do
        {
            do
            {
                Console.Write("Please enter n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            do
            {
                Console.Write("Please enter k: ");
            } while (!int.TryParse(Console.ReadLine(), out k));
        } while (1 >= k && k >= n && n >= 100);

        result = (BigInteger)CalculateFactorial(n) / (BigInteger)(CalculateFactorial(k) * CalculateFactorial(n - k));
        Console.WriteLine("The result is: " + result);
    }
}