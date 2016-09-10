using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Top row
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write("*");
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        // Middle part
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("*");

            for (int j = 0; j < (2 * n) - 2; j++)
            {
                Console.Write("/");
            }

            Console.Write("*");

            for (int p = 0; p < n; p++)
            {
                if (i == (n/2) - 1)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.Write("*");

            for (int q = 0; q < (2 * n) - 2; q++)
            {
                Console.Write("/");
            }

            Console.Write("*");
            Console.WriteLine();
        }

        // Bottom part
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write("*");   
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(" ");
        }

        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}
