// Calculate rectangle’s perimeter and area by given width and height
using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please enter height: ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Please enter width: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Perimeter is " + (height * 2 + width * 2));
        Console.WriteLine("Area is " + height * width);
    }
}