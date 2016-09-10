// Convert an integer number to its binary representation
using System;

class DecimalToBinary
{

    public static string StringReverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        long num;
        do
        {
            Console.Write("Please enter a number: ");
        } while(!long.TryParse(Console.ReadLine(), out num));

        string result = "";

        if (num != 0)
        {
            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    result += "1";
                }
                else
                {
                    result += "0";
                }
                num /= 2;
            }
        }
        else
        {
            result = "0";
        }

        Console.WriteLine("The result is: " + StringReverse(result));
    }
}