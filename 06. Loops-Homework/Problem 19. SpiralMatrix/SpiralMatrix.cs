// Print a matrix holding the numbers from 1 to n*n in the form of square spiral
using System;

class SpiralMatrix
{
    // TODO
    static void IncCursorPos(int currPos, int n)
    {
        if (currPos <= n)
        {
            Console.SetCursorPosition(0, currPos);
        }
        else if(currPos < 2 * n)
        {
            Console.SetCursorPosition(2 * n - (n - 1), n);
        }
    }

    static void Main()
    {
        int n;
        do
        {
            do
            {
                Console.Write("Please enter n: ");
            } while (!int.TryParse(Console.ReadLine(), out n));
        } while(n > 1 || n < 100);


    }
}