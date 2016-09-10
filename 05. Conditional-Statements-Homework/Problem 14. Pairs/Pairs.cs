using System;

class Pairs
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int prevSum, currSum = 0, maxDiff = 0;

        prevSum = int.Parse(input[0]) + int.Parse(input[1]);

        for (int i = 0; i < input.Length; i++)
        {
            currSum += int.Parse(input[i]);
            if (i != 0 && i % 2 != 0)
            {
                if (currSum - prevSum > maxDiff)
                {
                    maxDiff = currSum - prevSum;
                }
                else if (prevSum - currSum > maxDiff)
                {
                    maxDiff = prevSum - currSum;
                }
                
                prevSum = currSum;
                currSum = 0;
            }
        }

        if (maxDiff == 0)
        {
            Console.WriteLine("Yes, value=" + prevSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxDiff);
        }
    }
}