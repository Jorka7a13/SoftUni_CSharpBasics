// Print an isosceles triangle of 9 copyright symbols ©.

using System;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        char c = '\u00A9';
        int sizeOfTriangle = 3; // Change this to control the size of the triangle
        int j = sizeOfTriangle, k = sizeOfTriangle;

        for (int i = 0; i < sizeOfTriangle; i++)
        {
            for (int p = 0; p < j; p++)
            {
                Console.Write(" ");                
            }
            if (j != k)
            {
                Console.Write(c); // Prints the left char
            }
            for (int q = j + 1; q < k; q++)
            {
                Console.Write(" ");
            }
            j--; k++;
            Console.WriteLine(c); // Prints the right char
        }

        for (int l = 0; l < sizeOfTriangle + 1; l++) // Prints the bottom line of chars
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }
}
