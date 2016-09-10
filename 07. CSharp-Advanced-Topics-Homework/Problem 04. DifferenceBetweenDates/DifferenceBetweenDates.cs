// Returns the number of days between two given dates
using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        DateTime firstDate, secondDate;
        do
        {
            Console.Write("Please enter the first date: ");
        } while (!DateTime.TryParse(Console.ReadLine(), out firstDate));
        do
        {
            Console.Write("Please enter the second date: ");
        } while (!DateTime.TryParse(Console.ReadLine(), out secondDate));

        Console.WriteLine("The difference is: " + secondDate.Subtract(firstDate).Days);
    }
}