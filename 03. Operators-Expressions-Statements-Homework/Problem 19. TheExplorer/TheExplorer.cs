using System;

class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 0; row < n; row++) // Rows
        {
            for (int i = 0; i < n; i++) // Chars in row
            {
                if (row < n / 2 + 1) // Top half
                {
                    if (i == (n / 2) - row || i == (n / 2) + row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                else // Bottom half
                {
                    if (i == row - (n / 2) || i == (n - 1) - (row - (n / 2)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}