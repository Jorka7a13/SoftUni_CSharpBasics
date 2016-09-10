using System;

class NakovsMatching
{
    static int CalculateWight(string seq)
    {
        int result = 0;
        for (int i = 0; i < seq.Length; i++)
        {
            result += seq[i];
        }

        return result;
    }

    static int CalculateNakovs(string aLeft, string aRight, string bLeft, string bRight)
    {
        int nakovs = CalculateWight(aLeft) * CalculateWight(bRight) - CalculateWight(aRight) * CalculateWight(bLeft);

        if (nakovs < 0)
	    {
		    nakovs *= -1;
	    }
        return nakovs;
    }

    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int d = int.Parse(Console.ReadLine());

        string aLeft, aRight, bLeft, bRight;
        int currNakovs;
        int numOfMatches = 0;

        // Generate all possible combinations
        for (int i = 1; i < a.Length; i++)
        {
            aLeft = a.Substring(0, i);
            aRight = a.Substring(i);

            for (int j = 1; j < b.Length; j++)
            {
                bLeft = b.Substring(0, j);
                bRight = b.Substring(j);
                currNakovs = CalculateNakovs(aLeft, aRight, bLeft, bRight);

                if (currNakovs <= d)
                {
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", aLeft, aRight, bLeft, bRight, currNakovs);
                    numOfMatches++;
                }
            }
        }

        if (numOfMatches == 0)
        {
            Console.WriteLine("No");
        }
    }
}