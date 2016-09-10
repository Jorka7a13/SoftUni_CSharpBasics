// Check whether the product of the odd elements is equal to the product of the even elements
using System;

class OddEvenProduct
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] array = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!int.TryParse(input[i], out array[i]))
            {
                Console.WriteLine("Invalid input!");
                return;
            } 
        }

        int evenProduct = 1, oddProduct = 1;

        for (int i = 0, j = 1; i < array.Length; i++, j++)
        {
            if (j % 2 != 0)
            {
                oddProduct *= array[i];
            }
            else
            {
                evenProduct *= array[i];
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + oddProduct);
            Console.WriteLine("even_product = " + evenProduct);
        }
    }
}