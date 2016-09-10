using System;
using System.Linq;

class OddAndEvenJumps
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddJump = int.Parse(Console.ReadLine());
        int evenJump = int.Parse(Console.ReadLine());

        input = input.Replace(" ", "");
        input = input.ToLower();

        long oddResult = 0;
        long evenResult = 0;

        char[] oddLetters = new char[input.Length];
        char[] evenLetters = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
		{
			 if (i % 2 == 0)
            {
		        oddLetters[i] = input[i];
            } else
	        {
                 evenLetters[i] = input[i];
	        }
		}

        oddLetters = oddLetters.Where(val => val != (char)0).ToArray();
        evenLetters = evenLetters.Where(val => val != (char)0).ToArray();

        int oddStep = oddJump;
        for (int i = 0; i < oddLetters.Length; i++)
        {
            if (i != oddStep - 1) // Sum
            {
                oddResult += oddLetters[i];
            }
            else // Multiply
            {
                oddResult *= oddLetters[i];
                oddStep += oddJump;
            }
        }

        int evenStep = evenJump;
        for (int i = 0; i < evenLetters.Length; i++)
        {
            if (i != evenStep - 1) // Sum
            {
                evenResult += evenLetters[i];
            }
            else // Multiply
            {
                evenResult *= evenLetters[i];
                evenStep += evenJump;
            }
        }

        Console.WriteLine("Odd: {0:X}", oddResult);
        Console.WriteLine("Even: {0:X}", evenResult);
    }
}