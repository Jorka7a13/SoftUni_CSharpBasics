using System;
using System.Collections.Generic;

class NineDigitMagicNumbers
{

    static int[] IntToArray(int value)
    {
        var numbers = new Stack<int>();

        for (; value > 0; value /= 10)
            numbers.Push(value % 10);

        return numbers.ToArray();
    }

    static bool CheckNum(int[] array) // Checks if the number contains 8s or 9s or 0s
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 7 || array[i] < 1)
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int abc = 111, def, ghi, currSum = 0;
        bool hasResult = false;

        while (abc < 777)
        {
            if (CheckNum(IntToArray(abc)))
            {
                def = abc + diff;

                if (CheckNum(IntToArray(def)))
                {
                    ghi = def + diff;

                    if (CheckNum(IntToArray(ghi)))
                    {
                        currSum = 0;
                        int temp = abc;
                        while (temp != 0) {
                            currSum += temp % 10;
                            temp /= 10;
                        }

                        temp = def;
                        while (temp != 0)
                        {
                            currSum += temp % 10;
                            temp /= 10;
                        }

                        temp = ghi;
                        while (temp != 0)
                        {
                            currSum += temp % 10;
                            temp /= 10;
                        }

                        if (currSum == sum)
                        {
                            Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                            hasResult = true;
                        }

                    }
                }
            }

            abc++;
        }

        if (!hasResult)
        {
            Console.WriteLine("No");
        }
    }
}
