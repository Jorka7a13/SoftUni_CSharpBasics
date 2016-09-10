// Extract and print all URLs from given text
using System;
using System.Collections.Generic;

class ExtractURLsFromText
{
    static void Main()
    {
        List<string> URLlist = new List<string>();
        Console.Write("Please enter a text: ");
        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < input.Length; i++)
        {
            try
            {
                if (input[i].Substring(0, 7) == "http://" || (input[i].Substring(0, 4) == "www." && input[i].Contains(".")))
                {
                    if (input[i][input[i].Length - 1] == '.')
                    {
                        input[i] = input[i].Remove(input[i].Length - 1);
                    }
                    URLlist.Add(input[i]);
                }
            }
            catch (ArgumentOutOfRangeException) { };          
        }

        Console.WriteLine();
        Console.WriteLine("URLs: ");
        foreach (string url in URLlist)
        {
            Console.WriteLine(url);
        }
    }
}