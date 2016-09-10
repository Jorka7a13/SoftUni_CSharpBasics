using System;

class Volleyball
{
    static void Main()
    {
        string kindOfYear = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        double sum = 0;

        sum += (2.0/3.0) * p; // Add holidays
        sum += h; // Add hometown weekends
        sum += (3.0/4.0) * (48 - h); // Add normal weekends when not at work
        if (kindOfYear == "leap")
        {
            sum += (sum * 15) / 100;
        }

        Console.WriteLine((int)sum);
    }
}