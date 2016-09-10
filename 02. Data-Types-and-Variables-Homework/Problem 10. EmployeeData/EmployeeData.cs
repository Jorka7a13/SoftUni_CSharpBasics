// Declare the variables needed to keep the information for a single employee.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Sedef";
        string lastName = "Metropolski";
        byte age = 15;
        bool isMale = true;
        long ID = 8306112507;
        int employeeNum = 27569999;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.Write("Gender: ");
        if (isMale)
        {
            Console.WriteLine("Male");
        }
        else
        {
            Console.WriteLine("Female");
        }
        Console.WriteLine("Personal ID: " + ID);
        Console.WriteLine("Employee Number: " + employeeNum);
    }
}
