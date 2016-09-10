using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++) // Print top half
        {
            if (i == 0) // Print top row
            {
                for (int j = 0; j < (n * 2) - 1; j++)
                {
                    if (j < n / 2 || j >= (n / 2) + n)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
            }
            else // Print bottom rows of top half
            {
                for (int j = 0; j < (n * 2) - 1; j++)
                {
                    if (j == n / 2 || j == (n / 2) + (n - 1))
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }

        for (int j = 0; j < (n * 2) - 1; j++) // Print middle
        {
            if (j < (n / 2) + 1 || j > (n / 2) + (n - 2))
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();

        for (int i = 1; i < n; i++) // Print bottom half
        {
            for (int j = 0; j < (n * 2) - 1; j++)
            {
                if (j == i || j == ((n * 2) - 2) - i)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }
    }
}