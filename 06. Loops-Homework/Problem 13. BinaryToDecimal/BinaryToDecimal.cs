// Convert a binary integer number to its decimal form
using System;

class BinaryToDecimal
{

    public static string StringReverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        Console.Write("Please enter a binary number: ");
        string input = Console.ReadLine();

        long result = 0;
        input = StringReverse(input);

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '1')
            {
                result += (long)Math.Pow(2, i);
            }
        }

        Console.WriteLine("The result is: " + result);
    }
}