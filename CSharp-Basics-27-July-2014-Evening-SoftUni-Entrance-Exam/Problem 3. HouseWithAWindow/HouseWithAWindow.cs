using System;

class HouseWithAWindow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) // Print the roof
        {
            for (int j = 0; j < (n * 2) - 1; j++)
            {
                if (j == (n - i) - 1 || j == (n + i) - 1)
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
        for (int j = 0; j < (n * 2) - 1; j++) // Print the bottom of the roof
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++) // Print the base
        {
            if (i >= n / 4 && i < (n / 4) + (n / 2)) // Print the part with the window
            {
                for (int j = 0; j < (n * 2) - 1; j++) 
                {
                    if (j == 0 || j > n / 2 && j < ((n * 2) - 2) - n / 2 || j == (n * 2) - 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
            } 
            else // Print the part without the window
	        {
                for (int j = 0; j < (n * 2) - 1; j++)
                {
                    if (j == 0 || j == (n * 2) - 2)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
	        }
            Console.WriteLine();
        }

        for (int j = 0; j < (n * 2) - 1; j++) // Print the bottom of the base
        {
            Console.Write("*");
        }
    }
}