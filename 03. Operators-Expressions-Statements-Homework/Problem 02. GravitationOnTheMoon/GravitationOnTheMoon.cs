// Calculate the weight of a man on the moon
using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Please enter the weight on Earth: ");
        float weight = float.Parse(Console.ReadLine());
        weight *= 17f / 100f;
        Console.WriteLine(weight);
    }
}