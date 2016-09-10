using System;

class BitRoller
{

    static int GetRightNum(int num, int pos)
    {
        int mask = (int)Math.Pow(2, pos) - 1;
        return mask & num;
    }

    static int GetLeftNum(int num, int pos)
    {
        int mask1 = (int)Math.Pow(2, 19) - 1;
        int mask2 = (int)Math.Pow(2, (pos + 1)) - 1;
        int mask = mask1 ^ mask2;
        return (mask & num) >> (pos + 1);
    }

    static void RotateNums(ref int leftNum, ref int rightNum, int pos)
    {
        int mask;

        if (leftNum != 0 && rightNum != 0)
        {
            // Change right number
            int bitLeftNum = leftNum & 1;
            if (bitLeftNum > 0)
            {
                mask = 1 << pos;
                rightNum |= mask;
            }
            leftNum = leftNum >> 1;

            // Change left number
            int bitRightNum = rightNum & 1;
            if (bitRightNum > 0)
            {
                mask = 1 << (pos + 1);
                leftNum |= mask;
            }
            rightNum = rightNum >> 1;
        }
        else
        {
            // If frozen at 18
            if (rightNum != 0) 
            {
                int lastBit = rightNum & 1;
                if (lastBit > 0)
                {
                    mask = 1 << pos;
                    rightNum |= mask;
                }
                rightNum = rightNum >> 1;
            }
            // If frozen at 0
            else 
            {
                int firstBit = leftNum & 1;
                if (firstBit > 0)
                {
                    mask = 1 << pos;
                    leftNum |= mask;
                }
                leftNum = leftNum >> 1;
            }
        }
    }

    static int GetFrozenBit(int num, int pos)
    {
        int mask = 1 << pos;
        return (mask & num) >> pos;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());

        int leftNum = GetLeftNum(n, f);
        int rightNum = GetRightNum(n, f);
        int frozenBit = GetFrozenBit(n, f);
        for (int i = 0; i < r; i++)
        {
            RotateNums(ref leftNum, ref rightNum, f);
        }

        int result = leftNum << (f + 1);
        int mask = frozenBit << f;
        result |= mask;

        result |= rightNum;

        Console.WriteLine(result);
    }
}