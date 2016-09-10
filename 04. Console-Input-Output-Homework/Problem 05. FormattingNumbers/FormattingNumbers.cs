// Read 3 numbers and print them in 4 virtual columns
using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please enter an int: ");
        int a = int.Parse(Console.ReadLine());
        while (a < 0 || a > 500)
        {
            Console.Write("Please enter an int (0..500): ");
            a = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter a float: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please enter another float: ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("|{0,-10:X}|{1,10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}