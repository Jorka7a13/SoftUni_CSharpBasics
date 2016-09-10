using System;

class OddEvenSum
{
    static void Main()
    {
        int evenSum = 0, oddSum = 0; 
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < 2 * n + 1; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                evenSum += number;
            } 
            else
	        {
                oddSum += number;
        	}
        }

        if (evenSum == oddSum)
        {
            Console.WriteLine("Yes, sum=" + evenSum);
        }
        else
        {
            if (evenSum > oddSum)
	        {
		        Console.WriteLine("No, diff=" + (evenSum - oddSum));
            }
            else
            {
                Console.WriteLine("No, diff=" + (oddSum - evenSum));
            }
        }
    }
}