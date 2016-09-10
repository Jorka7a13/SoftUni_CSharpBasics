using System;

class ExamSchedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());

        if (partOfDay == "PM")
        {
            startHour += 12;
        }

        DateTime dateTime = new DateTime(1, 1, 1, startHour, startMinutes, 0);
        TimeSpan ts = new TimeSpan(durationHours, durationMinutes, 0);

        Console.WriteLine("{0:hh:mm:tt}", dateTime + ts);
    }
}

