using System;
using System.Collections.Generic;

class FiveSpecialLetters
{
    static int GetWeight(char c)
    {
        switch (c)
        {
            case 'a':
                return 5;
                break;
            case 'b':
                return -12;
                break;
            case 'c':
                return 47;
                break;
            case 'd':
                return 7;
                break;
            case 'e':
                return -32;
                break;
            default:
                return 0;
                break;
        }
    }

    static string RemoveRepeatingLetters(string input)
    {
        string temp = input;
        string result = input;
        char currChar;
        for (int i = input.Length - 1; i > 0; i--)
		{
            currChar = input[i];
            temp = temp.Remove(temp.Length - 1);
            if (temp.Contains(currChar.ToString()))
            {
                result = result.Remove(temp.Length, 1);
            }
		}
        return result;
    }

    static int CalculateWeight(string input)
    {
        input = RemoveRepeatingLetters(input);

        int result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            result += (i + 1) * GetWeight(input[i]);
        }

        return result;
    }

    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        char[] chars = { 'a', 'b', 'c', 'd', 'e' };

        List<string> resultList = new List<string>();
        string currString;

        for (int i1 = 0; i1 < 5; i1++)
        {
            for (int i2 = 0; i2 < 5; i2++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    for (int i4 = 0; i4 < 5; i4++)
                    {
                        for (int i5 = 0; i5 < 5; i5++)
                        {
                            currString = "" + (char)chars[i1] + chars[i2] + chars[i3] + chars[i4] + chars[i5];
                            if (CalculateWeight(currString) >= start && CalculateWeight(currString) <= end)
                            {
                                resultList.Add(currString);
                            }
                        }
                    }
                }
            }
        }

        resultList.Sort();
        if (resultList.Count > 0)
        {
            foreach (string seq in resultList)
            {
                Console.Write(seq + " ");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}