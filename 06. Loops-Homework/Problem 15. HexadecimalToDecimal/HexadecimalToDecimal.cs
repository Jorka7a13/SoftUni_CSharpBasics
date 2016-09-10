// Convert a hexadecimal integer number to its decimal form
using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a hex number: ");
        string input = Console.ReadLine();
        long result = 0;
        int power = input.Length - 1;
        int multiplier = 1;

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'A':
                    multiplier = 10;
                    break;
                case 'B':
                    multiplier = 11;
                    break;
                case 'C':
                    multiplier = 12;
                    break;
                case 'D':
                    multiplier = 13;
                    break;
                case 'E':
                    multiplier = 14;
                    break;
                case 'F':
                    multiplier = 15;
                    break;
                default:
                    multiplier = int.Parse(input[i].ToString());
                    break;
            }
            
            result += multiplier * (long)Math.Pow(16, power); // Convert input[i] ???
            power--;
        }

        Console.WriteLine("The result is: " + result);
    }
}