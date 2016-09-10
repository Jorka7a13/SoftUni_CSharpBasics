// Remove from the first list all names given in the second list
using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();
        List<string> firstList = new List<string>();
        List<string> secondList = new List<string>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            firstList.Add(firstInput[i]);
        }
        for (int i = 0; i < secondInput.Length; i++)
        {
            secondList.Add(secondInput[i]);
        }

        for (int i = 0; i < secondList.Count; i++)
        {
            if (firstList.Contains(secondList[i]))
            {
                firstList.RemoveAll(x => x.Equals(secondList[i]));
            }
        }

        foreach (string name in firstList)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}