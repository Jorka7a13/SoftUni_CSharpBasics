// Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
using System;

class CalculateFirstProblem
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
        int n, x;
        double sum = 1;

        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        do
        {
            Console.Write("Please enter x: ");
        } while (!int.TryParse(Console.ReadLine(), out x));

        for (int i = 1; i <= n; i++)
        {
            sum += CalculateFactorial(i) / Math.Pow(x, i);
        }

        Console.WriteLine("The result is: {0:F5}", sum);
    }
}