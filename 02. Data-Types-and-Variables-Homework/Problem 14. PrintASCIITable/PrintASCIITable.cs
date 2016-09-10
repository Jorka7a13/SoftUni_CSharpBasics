// Print the entire ASCII table.

using System;

class PrintASCIITable
{
    static void Main()
    {
        for (char ch = (char)0; ch < 256; ch++)
        {
            Console.Write(ch + " ");
        }
        Console.WriteLine();
    }
}
