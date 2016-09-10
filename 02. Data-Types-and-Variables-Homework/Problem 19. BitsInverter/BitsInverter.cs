using System;

class BitsInverter
{

    static int InvertBit(int number, int positionFromRight)
    {
        int result = (number & (1 << positionFromRight - 1)) >> positionFromRight - 1;
        
        if (result == 1)
        {
            number = number & ~(1 << positionFromRight - 1);
        }
        else if (result == 0)
        {
            number |= 1 << positionFromRight - 1;
        }

        return number;
    }

    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int[] resultArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int stepCount = 8;
        int stepResult = stepCount - step;

        // Invert the first number
        resultArray[0] = InvertBit(array[0], 8); 

        while (stepResult > 0)
        {
            resultArray[0] = InvertBit(resultArray[0], stepResult);
            stepResult -= step;
        }
        if (stepResult < 0)
        {
            stepResult *= -1;
        }

        for (int i = 1; i < n; i++) // For each number after the first
		{
            resultArray[i] = InvertBit(array[i], stepCount - stepResult);
            stepResult = (stepCount - stepResult) - step;

            while (stepResult > 0)
            {
                resultArray[i] = InvertBit(resultArray[i], stepResult);
                stepResult -= step;
            }
            if (stepResult < 0)
            {
                stepResult *= -1;
            }
		}

        foreach (var item in resultArray)
        {
            Console.WriteLine(item);
        }

    }
}
