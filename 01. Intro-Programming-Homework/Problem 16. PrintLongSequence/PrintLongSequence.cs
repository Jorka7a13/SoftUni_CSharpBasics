using System;

class PrintLongSequence
{
    static void Main()
    {
        int n = 2;
        for (int i = 0; i < 1000; i++)
        {
            Console.Write(n + " ");
            if (n < 0)
            {
                n *= -1;
                n++;
            }
            else
            {
                n++;
                n *= -1;
            }
        }
        Console.WriteLine();
    }
}
