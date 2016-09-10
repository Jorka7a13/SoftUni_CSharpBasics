using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Print the roof
        for (int i = 0; i < (n + 1) / 2; i++) 
        {
            if (i != ((n + 1) / 2) - 1) // If it's not the base of the roof
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == (n / 2) - i || j == (n / 2) + i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            else // Print the base of the roof
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
        }

        //Print the base
        for (int i = 0; i < n / 2; i++)
        {
            if (i != (n / 2) - 1) // If it is not the base of the base
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n / 4 || j == n - (n / 4) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < n; j++)
                {
                    if (j >= n / 4 && j <= n - (n / 4) - 1)
                    {
                        Console.Write("*");
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
}