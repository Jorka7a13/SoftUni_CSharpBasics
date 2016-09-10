using System;

class BitSifting
{
    static void UnsetBit(ref ulong number, int position)
    {
        number &= ~(1ul << position);
    }

    static bool IsBitSet(ulong number, int position)
    {
        if ((number & (1ul << position)) >> position == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong[] sieves = new ulong[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            sieves[i] = ulong.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 64; i++) // For each digit in number
        {
            if (IsBitSet(number, i))
            {
                for (int j = 0; j < n; j++) // For each sieve
                {
                    if (IsBitSet(sieves[j], i))
                    {
                        UnsetBit(ref number, i);
                    }
                }
            }
        }

        for (int i = 0; i < 64; i++) // Count ones in number
        {
            if (IsBitSet(number, i))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}