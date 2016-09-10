// print all possible cards from a standard deck of 52 cards
using System;

class PrintADeckOfCards
{
    static void Main()
    {
        for (int i = 2; i < 15; i++) // Iterate faces
        {
            for (int j = 0; j < 4; j++) // Iterate suits
            {
                if (i < 11)
                {
                    Console.Write(i);
                }
                else
                {
                    switch (i)
                    { 
                        case 11:
                            Console.Write("J");
                            break;
                        case 12:
                            Console.Write("Q");
                            break;
                        case 13:
                            Console.Write("K");
                            break;
                        case 14:
                            Console.Write("A");
                            break;
                    }
                }
                
                switch (j)
                {
                    case 0:
                        Console.Write((char)005 + " ");
                        break;
                    case 1:
                        Console.Write((char)004 + " ");
                        break;
                    case 2:
                        Console.Write((char)003 + " ");
                        break;
                    case 3:
                        Console.Write((char)006 + " ");
                        break;
                }       
            }
            Console.WriteLine();
        }
    }
}