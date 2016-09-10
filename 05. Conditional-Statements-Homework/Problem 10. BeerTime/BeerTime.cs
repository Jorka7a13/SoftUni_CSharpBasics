// A beer time is after 1:00 PM and before 3:00 AM. Print “beer time” or “non-beer time” according to this definition.
using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Please enter a time: ");
        DateTime time;
        DateTime startTime = new DateTime();
        DateTime endTime = new DateTime();

        TimeSpan ts = new TimeSpan(13, 00, 0);
        startTime = startTime.Date + ts;
        ts = new TimeSpan(3, 00, 0);
        endTime = endTime.Date + ts;

        if (DateTime.TryParse(Console.ReadLine(), out time)) 
        {
            if (time.TimeOfDay < startTime.TimeOfDay && time.TimeOfDay >= endTime.TimeOfDay)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}