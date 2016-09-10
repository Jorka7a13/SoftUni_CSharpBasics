// Generate a matrix of palindromes of 3 letters with given rows and columns
using System;

class MatrixOfPalindromes
{
    static void PrintPalindrome(int r, int c)
    {
        Console.Write((char)('a' + r));
        Console.Write((char)(('a' + r) + c));
        Console.Write((char)('a' + r));
        Console.Write(' ');
    }

    static void Main()
    {
        int r, c;
        string[] input = Console.ReadLine().Split();

        r = int.Parse(input[0]);
        c = int.Parse(input[1]);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                PrintPalindrome(i, j);
            }
            Console.WriteLine();
        }
    }
}