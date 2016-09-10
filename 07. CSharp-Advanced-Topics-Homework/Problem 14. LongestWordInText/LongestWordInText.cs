// Find the longest word in a text
using System;

class LongestWordInText
{
    static void Main()
    {
        Console.Write("Please enter a text: ");
        string[] input = Console.ReadLine().Split(' ', '.', ',', '!', '?', ';', ':');

        int maxLenght = input[0].Length;
        int indexOfLongestWord = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length > maxLenght)
            {
                maxLenght = input[i].Length;
                indexOfLongestWord = i;
            }
        }

        Console.WriteLine("The longest word is: " + input[indexOfLongestWord]);
    }
}