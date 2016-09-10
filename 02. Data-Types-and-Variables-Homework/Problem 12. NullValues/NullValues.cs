// Assign null values to an integer and to a double variable.

using System;

class NullValues
{
    static void Main()
    {
        int? i = null;
        double? d = null;

        Console.WriteLine("int: {0}", i);
        Console.WriteLine("double: {0}", d);

        i += 7;
        d += null;

        Console.WriteLine("int: {0}", i);
        Console.WriteLine("double: {0}", d);
    }
}
