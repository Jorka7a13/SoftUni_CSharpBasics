// Enter a string and prints “yes” if it is a valid card sign or “no” otherwise
using System;
using System.Collections.Generic;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        string sign = Console.ReadLine();
        List<string> cardSigns = new List<string>();
        cardSigns.Add("2");
        cardSigns.Add("3");
        cardSigns.Add("4");
        cardSigns.Add("5");
        cardSigns.Add("6");
        cardSigns.Add("7");
        cardSigns.Add("8");
        cardSigns.Add("9");
        cardSigns.Add("10");
        cardSigns.Add("J");
        cardSigns.Add("Q");
        cardSigns.Add("K");
        cardSigns.Add("A");

        if (cardSigns.Contains(sign))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}