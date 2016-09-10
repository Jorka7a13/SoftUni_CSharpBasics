using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leap;
        int p, h;
        double count = 0;

        leap = Console.ReadLine();
        p = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());

        if (leap.Equals("t")) // Leap year days
        {
            count += 3;
        }

        count += h; // Hometown weekends
        count += p * 1.0 / 2.0; // Holidays
        count += (2.0/3.0) * (52 - h); // Normal weekends when Joro is not tired

        Console.WriteLine((int)count);
    }
}
