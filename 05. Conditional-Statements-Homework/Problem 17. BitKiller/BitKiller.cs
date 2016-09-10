using System;

class BitKiller
{

    static void UnsetBeforePos(ref byte n, byte posFromLeft)
    {
        byte mask = 1 << (7 - posFromLeft);

        for (byte i = 0; i < posFromLeft; i++)
        {
            mask = mask << 1;
            n &= ~mask;
        }
    }

    static void Main()
    {

        byte n = byte.Parse(Console.ReadLine());
        //int step = int.Parse(Console.ReadLine());
        //int[] array = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    array[i] = int.Parse(Console.ReadLine());
        //}

        int result, temp = 1;

        result = n & (1 << 7); // get the first bit

        UnsetBeforePos(ref n, 2);

        Console.WriteLine(n);

        temp = n << 2; // TO FIX (after the 8th bit don't go to the 9th)

        Console.WriteLine(temp);
    
    }
}