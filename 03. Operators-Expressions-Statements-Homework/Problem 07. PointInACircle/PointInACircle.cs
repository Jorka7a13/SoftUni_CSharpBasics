// Check if a given point is inside a circle K({0, 0}, 2)
using System;

class PointInACircle
{
    static void Main()
    {
        double center_x = 0.0;
        double center_y = 0.0;
        double radius = 2;

        Console.Write("Please enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter Y: ");
        double y = double.Parse(Console.ReadLine());

        if (((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y)) <= (radius * radius))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}