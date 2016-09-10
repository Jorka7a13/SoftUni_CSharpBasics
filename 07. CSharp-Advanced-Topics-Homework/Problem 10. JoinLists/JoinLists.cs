// Take two lists of integers and joins them
using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        string[] firstInput = Console.ReadLine().Split();
        string[] secondInput = Console.ReadLine().Split();
        List<int> firstList = new List<int>();
        List<int> secondList = new List<int>();

        for (int i = 0; i < firstInput.Length; i++)
        {
            firstList.Add(int.Parse(firstInput[i]));
        }
        for (int i = 0; i < secondInput.Length; i++)
        {
            secondList.Add(int.Parse(secondInput[i]));
        }

        for (int i = 0; i < secondList.Count; i++)
        {
            firstList.Add(secondList[i]);
        }

        List<int> resultList = firstList.Distinct().ToList();
        resultList.Sort();

        foreach (int num in resultList)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}