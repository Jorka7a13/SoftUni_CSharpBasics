using System;

class AgeAfterTenYears
{
    static void Main()
    {
        int year = 0;
        while (year < 1 || year > DateTime.Now.Year)
        {
            Console.Write("Please enter your birth year: ");
            year = Int32.Parse(Console.ReadLine());
        }

        Console.WriteLine("After ten years you will be " + ((DateTime.Now.Year - year) + 10) + " years old!");
    }
}

