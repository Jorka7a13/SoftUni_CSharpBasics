using System;

class Triangle
{
    static void Main()
    {
        int Ax = int.Parse(Console.ReadLine());
        int Ay = int.Parse(Console.ReadLine());
        int Bx = int.Parse(Console.ReadLine());
        int By = int.Parse(Console.ReadLine());
        int Cx = int.Parse(Console.ReadLine());
        int Cy = int.Parse(Console.ReadLine());

        double a = Math.Sqrt((Bx - Ax) * (Bx - Ax) + (By - Ay) * (By - Ay));
        double b = Math.Sqrt((Cx - Bx) * (Cx - Bx) + (Cy - By) * (Cy - By));
        double c = Math.Sqrt((Cx - Ax) * (Cx - Ax) + (Cy - Ay) * (Cy - Ay));


        if ((a + b > c) && (b + c > a) && (a + c > b))
        {
            Console.WriteLine("Yes");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("{0:F2}", area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", a);
        }
    }
}