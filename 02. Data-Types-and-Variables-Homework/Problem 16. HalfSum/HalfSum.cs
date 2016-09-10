using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n*2];
        int leftSum = 0, rightSum = 0;
        int diff;

        for (int i = 0; i < n * 2; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            leftSum += array[i];
        }

        for (int i = n; i < n * 2; i++)
        {
            rightSum += array[i];
        }

        if (leftSum == rightSum)
        {
            Console.WriteLine("Yes, sum = " + leftSum);
        }
        else
        {
            Console.Write("No, diff = ");
            diff = leftSum - rightSum;

            if (diff < 0)
            {
                diff *= -1;
            }

            Console.WriteLine(diff);
        }
    }
}
