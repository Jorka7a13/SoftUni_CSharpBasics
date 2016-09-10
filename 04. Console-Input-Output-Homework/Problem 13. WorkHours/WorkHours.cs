using System;

class WorkHours
{
    static void Main()
    {

        int h = int.Parse(Console.ReadLine()); // Required hours
        int d = int.Parse(Console.ReadLine()); // Work days available
        int p = int.Parse(Console.ReadLine()); // Productivity (in percent)
        
        double workDays = d - (d / 10.0); // Subtract biking days
        int workHours = (int)(workDays * 12 * (p / 100.0));

        if (workHours >= h)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        Console.WriteLine(workHours - h);
    }
}