// Check if given point is within the circle K({1, 1}, 1.5) 
// and out of the rectangle R(top=1, left=-1, width=6, height=2)
using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        double center_x = 1.0;
        double center_y = 1.0;
        double radius = 1.5;

        Console.Write("Please enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please enter Y: ");
        double y = double.Parse(Console.ReadLine());

        if (((x - center_x) * (x - center_x) + (y - center_y) * (y - center_y)) <= (radius * radius)) // Inside circle
        {
            if (x < -1 || x > 5 || y > 1 || y < -1) // Outside rectangle
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}