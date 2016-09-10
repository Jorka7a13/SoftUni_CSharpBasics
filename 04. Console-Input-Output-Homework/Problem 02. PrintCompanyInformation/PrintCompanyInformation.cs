// Read the info about a company and its manager and print it back on the console
using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Please enter a company name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter a company address: ");
        string address = Console.ReadLine();
        Console.Write("Please enter a company phone number: ");
        string compPhoneNum = Console.ReadLine();
        Console.Write("Please enter company fax number: ");
        string faxNum = Console.ReadLine();
        Console.Write("Please enter a company web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Please enter a manager's first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter a manager's last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Please enter a manager's age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Please enter a manager's phone number: ");
        string manPhoneNum = Console.ReadLine();

        Console.WriteLine(name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Tel. " + compPhoneNum);
        Console.Write("Fax: ");
        if (faxNum != "")
        {
            Console.WriteLine(faxNum);
        }
        else
        {
            Console.WriteLine("(no fax)");
        }
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: " + firstName + " " + lastName + " (age: " + age + ", " + "tel. " + manPhoneNum + ")");
    }
}