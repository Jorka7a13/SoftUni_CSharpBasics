﻿// Print for each letter how many times it appears in the list
using System;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        Array.Sort<string>(input);

        var result = input.GroupBy(a => a);

        foreach (var group in result)
        {
            Console.Write("{0} -> ", group.Key);
            Console.WriteLine(group.Count());
        }
    }
}