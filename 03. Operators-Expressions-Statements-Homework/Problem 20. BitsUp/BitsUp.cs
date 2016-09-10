using System;

class BitsUp
{

    static void SetBitToOne(ref int number, int positionFromLeft)
    {
        number |= 1 << (7 - positionFromLeft); 
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int calcStep = 1;

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++) // All numbers
        {
            while (calcStep < 7)
            {
                SetBitToOne(ref array[i], calcStep);
                calcStep += step;
            }

            calcStep -= 8;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}