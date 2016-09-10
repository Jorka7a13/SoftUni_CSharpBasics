// Find the longest area of equal elements in array of strings
using System;
using System.Linq;
using System.Collections.Generic;

class LongestAreaInArray
{
    static string[] GetLongestEqualElems(List<string[]> list)
    {
        int maxArea = list[0].Count(s => s != null);
        string[] maxAreaElems = list[0];

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Count(s => s != null) > maxArea)
            {
                maxArea = list[i].Count(s => s != null);
                maxAreaElems = list[i];
            }
        }
        return maxAreaElems;
    }

    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter n: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        List<string[]> list = new List<string[]>();
        string[] input = new string[n];

        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
        }

        string currString = input[0];
        string[] currArray = new string[n];

        for (int i = 0, j = 0; i < n; i++, j++)
        {
            // If the next element is different from the previous
            if (!input[i].Equals(currString))
            {
                list.Add(currArray);
                j = 0;
                currArray = new string[n];
            }
            currString = input[i];
            currArray[j] = currString;

            // If this is the last element
            if (i == n - 1)
            {
               list.Add(currArray); 
            }
        }

        string[] result = GetLongestEqualElems(list);
        Console.WriteLine(result.Count(s => s != null));

        for (int i = 0; i < result.Count(s => s != null); i++)
        {
            Console.WriteLine(result[i]);
        }
    }
}