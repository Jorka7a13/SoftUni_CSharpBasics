// Calculate a trapezoid's area by given sides and height
using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Please enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter height: ");
        double height = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2.0) * height;
        Console.WriteLine("Area is " + area);
    }
}