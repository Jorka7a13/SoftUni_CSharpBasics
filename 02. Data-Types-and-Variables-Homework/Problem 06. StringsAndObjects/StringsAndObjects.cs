// Declare two string variables. Declare an object variable and assign it with their concatenation.  

using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World!";
        object obj = firstWord + " " + secondWord;
        string message = (string) obj;

        Console.WriteLine(message);
    }
}
