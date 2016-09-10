// Read the radius of a circle and print its perimeter and area formatted with 2 digits after the decimal point
using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Please enter a radius: ");
        double r = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter is {0:#.##}", 2 * Math.PI * r);
        Console.WriteLine("Area is {0:#.##}", Math.PI * r * r);
    }
}