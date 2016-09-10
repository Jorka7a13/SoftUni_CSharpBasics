using System;

class PrintSequence
{
    static void Main()
    {
        int n = 2;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(n);
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
    }
}
