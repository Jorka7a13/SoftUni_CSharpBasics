// Convert a number in the range [0…999] to words
using System;

class NumberAsWords
{

    static string numberAsWords = "";

    public static string FirstCharToUpper(string input)
    {
        if (String.IsNullOrEmpty(input))
            throw new ArgumentException();
        return input[0].ToString().ToUpper() + input.Substring(1);
    } // Makes the first char a capital letter

    static void GenerateOnes(int num)
    {
        switch (num)
        {
            case 1:
                numberAsWords += "one";
                break;
            case 2:
                numberAsWords += "two";
                break;
            case 3:
                numberAsWords += "three";
                break;
            case 4:
                numberAsWords += "four";
                break;
            case 5:
                numberAsWords += "five";
                break;
            case 6:
                numberAsWords += "six";
                break;
            case 7:
                numberAsWords += "seven";
                break;
            case 8:
                numberAsWords += "eight";
                break;
            case 9:
                numberAsWords += "nine";
                break;
        }

    } // Prints [1.. 9]

    static void GenerateTeens(int num)
    {
        if (num == 0)
        {
            numberAsWords += "zero";
        } 
        else if (num > 0 && num < 10)
        {
            GenerateOnes(num);
        }
        else
        {
            switch (num)
            {
                case 10:
                    numberAsWords += "ten";
                    break;
                case 11:
                    numberAsWords += "eleven";
                    break;
                case 12:
                    numberAsWords += "twelve";
                    break;
                case 13:
                    numberAsWords += "thirteen";
                    break;
                case 14:
                    numberAsWords += "fourteen";
                    break;
                case 15:
                    numberAsWords += "fifteen";
                    break;
            }

            if (num > 15 && num < 20)
            {
                GenerateOnes(num % 10);
                if (num % 10 == 8)
                {
                    numberAsWords += "een";
                }
                else
                {
                    numberAsWords += "teen";
                }
            }
        }
    } // Prints [0.. 19]

    static void GenerateTens(int num) // Prints [0.. 99]
    {
        if (num < 20)
        {
            GenerateTeens(num);
        }
        else
        {
            int temp = num / 10;
            switch (temp) 
            {
                case 2:
                    numberAsWords += "twenty";
                    break;
                case 3:
                    numberAsWords += "thirty";
                    break;
                case 4:
                    numberAsWords += "fourty";
                    break;
                case 5:
                    numberAsWords += "fifty";
                    break;
                case 6:
                    numberAsWords += "sixty";
                    break;
                case 7:
                    numberAsWords += "seventy";
                    break;
                case 8:
                    numberAsWords += "eighty";
                    break;
                case 9:
                    numberAsWords += "ninety";
                    break;
            }
            numberAsWords += " ";
            GenerateOnes(num % 10);
        }
    }

    static void GenerateHundreds(int num) // Prints [0.. 999]
    {
        if (num < 100)
        {
            GenerateTens(num);
        }
        else
        {
            GenerateOnes(num / 100);
            numberAsWords += " hundred";

            if (num % 100 != 0)
            {
                numberAsWords += " and ";
                GenerateTens(num % 100);    
            }
        }
    }

    static void Main()
    {
        int num;
        do
        {
            Console.Write("Please enter a number: ");
        }
        while(!int.TryParse(Console.ReadLine(), out num) || num < 0 || num > 999);

        GenerateHundreds(num);
        Console.WriteLine(FirstCharToUpper(numberAsWords));
    }
}