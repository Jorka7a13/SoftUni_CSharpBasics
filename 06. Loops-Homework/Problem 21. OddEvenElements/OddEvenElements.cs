using System;
using System.Linq;

class OddEvenElements
{
    static string PrintSum(double[] array)
    {
        double sum = 0;
        if (array == null || array.Length == 0)
        {
            return "No";
        }

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }

        return sum.ToString();
    }

    static string PrintMin(double[] array)
    {
        if (array == null || array.Length == 0)
        {
            return "No";
        }

        double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (min > array[i])
            {
                min = array[i]; 
            }
        }
        return min.ToString();
    }

    static string PrintMax(double[] array)
    {
        if (array == null || array.Length == 0)
        {
            return "No";
        }

        double max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }
        return max.ToString();
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        double[] oddArray = new double[input.Length];
        double[] evenArray = new double[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if ((i + 1) % 2 != 0)
            {
                oddArray[i] = double.Parse(input[i]);
            }
            else
            {
                evenArray[i] = double.Parse(input[i]);
            }
        }

        oddArray = oddArray.Where(val => val != 0).ToArray();
        evenArray = evenArray.Where(val => val != 0).ToArray();

        Console.WriteLine("OddSum=" + PrintSum(oddArray) + ", OddMin=" + PrintMin(oddArray) + ", OddMax=" + PrintMax(oddArray) +
            ", EvenSum=" + PrintSum(evenArray) + ", EvenMin=" + PrintMin(evenArray) + ", EvenMax=" + PrintMax(evenArray));
    }
}