using System;

class ChangeEvenBits
{
    static int GetBitAtPos(int num, int pos)
    {
        int mask = 1 << pos;
        return num = (num & mask) >> pos;
    }

    static int CountBits(int num)
    {
        int count = 0;

        while (GetBitAtPos(num, 16) != 1)
        {
            num = num << 1;
            count++;
        }
        
        return (16 - count) + 1;
    }

    static bool SetBit(ref ulong num, int pos)
    {
        bool result = false;
        ulong one = 1;
        
        ulong digit;
        ulong maskOne = one << pos;
        digit = (num & maskOne) >> pos;

        if (digit == 0)
        {
            result = true;
        }

        ulong maskTwo = one << pos;
        num |= maskTwo;
        return result;
    }

    static ulong SetEvenBits(ref ulong num, int len)
    {
        int index = 0;
        ulong result = 0;
        for (int i = 0; i < len; i++)
        {
            if (SetBit(ref num, index))
            { 
                result++;
            }
            index += 2;
        }
        return result;
    }

    static int[] GenerateEvenPos(int num)
    {
        int[] array = new int[num];

        for (int i = 0; i < num; i++)
        {
            if (i > 0)
            {
                array[i] = array[i - 1] + 2;
            }
            else
            {
                array[i] = 0;
            }
        }

        return array;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        ulong l = ulong.Parse(Console.ReadLine());

        int len;
        ulong changedBits = 0;

        for (int i = 0; i < array.Length; i++)
        {
            len = CountBits(array[i]);
            changedBits += SetEvenBits(ref l, len);

        }

        Console.WriteLine(l);
        Console.WriteLine(changedBits);
    }
}