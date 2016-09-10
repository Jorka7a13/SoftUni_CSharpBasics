using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= Math.Ceiling(n / 2.0); i++) // Print roof
        {
            for (int j = 0; j < n; j++)
            {
                if (j > n / 2 - i && j < n / 2 + i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("-");
                }
            }

            Console.WriteLine();
        }

        for (int i = 0; i < n; i++) // Print floor
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write('*');
                }
            }
            Console.WriteLine();
        }
    }
}