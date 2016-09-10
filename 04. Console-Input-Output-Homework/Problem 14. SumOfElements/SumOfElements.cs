using System;

class SumOfElements
{
    static void Main()
    {

        string[] array = Console.ReadLine().Split(' ');
        int currSum = 0, currNum, currDiff;
        bool isFound = false;

        for (int i = 1; i < array.Length; i++)
        {
            currSum += int.Parse(array[i]);
        }

        int minDiff = (int.Parse(array[0]) - currSum); // Calculate the first minimal difference
        if (minDiff < 0)
        {
            minDiff *= -1;
        }
        
        for (int i = 0; i < array.Length; i++) // Get each element
        {
            currNum = int.Parse(array[i]);
            currSum = 0;
            currDiff = 0;

            for (int j = 0; j < array.Length; j++) // Sum the other elements
            {
                if (i != j) // Don't sum the currently picked element
                {
                    currSum += int.Parse(array[j]);
                }
            }

            currDiff = currNum - currSum; // Calculate the current difference
            if (currDiff < 0)
            {
                currDiff *= -1;
            }

            if (currDiff < minDiff) // If it is lower that the minimal difference, this is the new minimal one
	        {
		        minDiff = currDiff;
	        }

            if (currNum == currSum)
            {
                Console.WriteLine("Yes, sum=" + currSum);
                isFound = true;
                break;
            }

            if (minDiff < 0)
            {
                minDiff *= -1;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No, diff=" + minDiff);
        }
    }
}