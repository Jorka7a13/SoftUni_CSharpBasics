using System;

class MagicDates
{

    static int CalculateWeight(int num)
    {
        int digit, temp, sum = 0;

        for (int i = 0; i < 8; i++)
        {
            digit = num % 10;
            num /= 10;
            temp = num;

            for (int j = 0; j < 8; j++)
            {
                sum += digit * (temp % 10);
                temp /= 10;
            }
        }
        return sum;
    }

    static void Main()
    {
        DateTime startDate = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        DateTime endDate = new DateTime(int.Parse(Console.ReadLine()), 12, 31);
        int magicWeight = int.Parse(Console.ReadLine());
        int intDate;
        bool foundDate = false;

        
        while (startDate <= endDate)
        {
            intDate = startDate.Day * 1000000 + startDate.Month * 10000 + startDate.Year;
            if (CalculateWeight(intDate) == magicWeight)
            {
                Console.WriteLine("{0:dd-MM-yyyy}", startDate);
                foundDate = true;
            }
            startDate = startDate.AddDays(1);
        }

        if (!foundDate)
        {
            Console.WriteLine("No");
        }
    }
}