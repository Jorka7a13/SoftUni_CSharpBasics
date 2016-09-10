// Convert an integer number to its hexadecimal representation
using System;

class DecimalToHexadecimal
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
        } while (!long.TryParse(Console.ReadLine(), out num));

        string result = "";
        long currRes;

        while (num > 0)
        {
            currRes = num % 16;

		    switch (currRes)
	        {
                case 10:
                    result += "A";
                    break;
                case 11:
                    result += "B";
                    break;
                case 12:
                    result += "C";
                    break;
                case 13:
                    result += "D";
                    break;
                case 14:
                    result += "E";
                    break;
                case 15:
                    result += "F";
                    break;
		        default:
                    result += currRes;
                    break;
	        }
            num /= 16;
        }

        result = StringReverse(result);
        Console.WriteLine(result);
    }
}