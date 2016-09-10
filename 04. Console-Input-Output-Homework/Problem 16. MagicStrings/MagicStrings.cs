using System;
using System.Collections.Generic;

class MagicStrings
{

    static int CalculateWeight(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }

    static bool ContainsIllegalWeights(int num)
    {
        while (num != 0)
        {
            if (num % 10 == 0 || num % 10 == 2 || num % 10 > 5)
            {
                return true;
            }
            num /= 10;
        }
        return false;
    }

    static void FormatStrings(ref List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].Replace('1', 'k');
            list[i] = list[i].Replace('3', 's');
            list[i] = list[i].Replace('4', 'n');
            list[i] = list[i].Replace('5', 'p');
        }
    }

    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        List<string> result = new List<string>();

        for (int firstSeq = 1111; firstSeq <= 5555; firstSeq++)
        {
            if (!ContainsIllegalWeights(firstSeq))
            {
                for (int secondSeq = 1111; secondSeq <= 5555; secondSeq++)
                {
                    if (!ContainsIllegalWeights(secondSeq))
                    {
                        if (CalculateWeight(secondSeq) == CalculateWeight(firstSeq) + diff || CalculateWeight(firstSeq) == CalculateWeight(secondSeq) + diff)
                        {
                            result.Add("" + firstSeq + secondSeq);
                        }
                    }
                }
            }
        }

        if (result.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            FormatStrings(ref result);
            result.Sort();
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}