// Depending on the user’s choice, input an int, double or string variable and do stuff with it
using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(++i);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine(++d);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string s = Console.ReadLine();
                s += "*";
                Console.WriteLine(s);
                break;
            default:
                Console.Write("No such choice, sorry!");
                break;
        }
    }
}