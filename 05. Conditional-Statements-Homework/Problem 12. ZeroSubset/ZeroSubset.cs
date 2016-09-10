// Find all subsets of five numbers whose sum is 0
using System;
using System.Collections.Generic;

class ZeroSubset
{

    static void Main()
    {
        int num, sum;
        bool isThereSubset = false, subsetChanged = false;
        int[] array = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Please enter a number: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Please enter an int: ");
                array[i] = num;
            }
            array[i] = num;
        }

        // Calculating the combinations
        for (int i = 0; i < Convert.ToInt32(Math.Pow(2, 5)); i++)
		{
            List<int> nestedList = new List<int>();
            sum = 0;
            for (int j = 0; j < 5; j++)
            {
                var pos = 1 << j;
                if ((i & pos) == pos) 
                { 
                    nestedList.Add(array[j]);
                    sum += array[j];
                    subsetChanged = true;
                }
            }

            // If the current combination sums to 0, print it
            if (sum == 0 && subsetChanged)
            {
                isThereSubset = true;
                for (int k = 0; k < nestedList.Count; k++ )
                {
                    if (k != nestedList.Count - 1)
                    {
                        Console.Write(nestedList[k] + " + ");
                    }
                    else
                    {
                        Console.Write(nestedList[k]);
                    }
                }
                Console.WriteLine(" = 0");
            }
        }

        if (!isThereSubset)
        {
            Console.WriteLine("no zero subset");
        }
    }
}