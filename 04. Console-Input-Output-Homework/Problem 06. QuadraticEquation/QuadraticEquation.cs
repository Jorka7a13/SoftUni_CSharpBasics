// Solve a quadratic equation
using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Please enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("This is linear equation!");
            double x = -c / b;
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0}; x2 = {1}", x1, x2);
            }
            else if(d == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x);
            }
            else if (d < 0)
            {
                Console.WriteLine("No real roots!");
            }
        }
    }
}