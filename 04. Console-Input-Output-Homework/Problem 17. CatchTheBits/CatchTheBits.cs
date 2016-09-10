using System;
using System.Collections.Generic;

class CatchTheBits
{

    static int GetBitAtPos(int number, int pos)
    { 
        int result = number & (1 << (7 - pos)); 
        return result >> (7 - pos);
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        string result = "";
        int currPos = 1;
        List<int> resultList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; )
        {
            result += GetBitAtPos(array[i], currPos);
            currPos += step;

            if (currPos > 7)
            {
                i++;

                if (result.Length == 8)
                {
                    if (result.Contains("1"))
                    {
                        resultList.Add(Convert.ToInt32(result, 2));
                    }
                    result = "";
                }

                currPos -= 8;
            }
        }

        if (result.Length < 8 && result.Contains("1"))
        {
            result = result.PadRight(8, '0');
            resultList.Add(Convert.ToInt32(result, 2));
        }

        foreach (int item in resultList)
        {
            Console.WriteLine(item);
        }
    }
}