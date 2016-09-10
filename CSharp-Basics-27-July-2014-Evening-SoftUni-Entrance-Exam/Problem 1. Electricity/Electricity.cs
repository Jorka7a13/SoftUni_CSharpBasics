using System;

class Electricity
{

    static double GetWattsPerFlat(DateTime time)
    {
        double lamp = 100.53;
        double pc = 125.90;
        double result = 0;

        DateTime morningStart = new DateTime(1, 1, 1, 0, 0, 0);
        DateTime morningEnd = new DateTime(1, 1, 1, 8, 59, 0);
        DateTime afternoonStart = new DateTime(1, 1, 1, 14, 0, 0);
        DateTime afternoonEnd = new DateTime(1, 1, 1, 18, 59, 0);
        DateTime eveningStart = new DateTime(1, 1, 1, 19, 0, 0);
        DateTime eveningEnd = new DateTime(1, 1, 1, 23, 59, 0);

        if (time.TimeOfDay >= morningStart.TimeOfDay && time.TimeOfDay <= morningEnd.TimeOfDay)
        {
            result = lamp + 8 * pc;
        }
        else if (time.TimeOfDay >= afternoonStart.TimeOfDay && time.TimeOfDay <= afternoonEnd.TimeOfDay)
        {
            result = 2 * lamp + 2 * pc;
        }
        else if (time.TimeOfDay >= eveningStart.TimeOfDay && time.TimeOfDay <= eveningEnd.TimeOfDay)
        {
            result = 7 * lamp + 6 * pc;
        }

        return result;
    }

    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime time = DateTime.Parse(Console.ReadLine());
        double result = 0;

        for (int i = 0; i < floors * flats; i++)
        {
            result += GetWattsPerFlat(time);
        }

        Console.WriteLine((int)result + " Watts");
    }
}