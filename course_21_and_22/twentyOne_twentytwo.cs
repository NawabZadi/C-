using System;
public class Employee
{
    public string? FirstName;
    public string? LastName;
    public string? Email;

    public void PrintFullName()
    {
        Console.WriteLine("FirstName {0} LastName {1}", FirstName, LastName);
    }
}

public class FullTimeEmployee : Employee
{
    //this function hides the parent method so to avoid warning we will add 'new' keyword
    public new void PrintFullName()
    {
        //PART 22 
        //Method hiding
        //it will print base class method
        base.PrintFullName();
       // Console.WriteLine("FirstName {0} LastName {1}  - contrator", FirstName, LastName);
    }
}

public class HalfTimeEmployee : Employee
{
    public float HourlyRate;
}
class twentyOne_To_Thirty
{
    public static void Main()
    {
        //PART 21
        // INHERITANCE
        // C# does not support multiple inheritance
        
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = ""; //now it can have null value also
        FTE.LastName = "Tech";
        // Not a property of full-time employee class. Since inheriting from employee class these properties can be accessed
        //FTE.YearlySalary = 50000; // Uncomment this line if you add YearlySalary to FullTimeEmployee
        FTE.PrintFullName();

        //we can create this because a child class have all the attibutes and objects of base class
        // Employee PTE = new HalfTimeEmployee();
        HalfTimeEmployee PTE = new HalfTimeEmployee(); // Corrected variable declaration
        PTE.FirstName = "Part";
        PTE.LastName = "Time";
        //PTE.PrintFullName();->Employee PTE = new HalfTimeEmployee();
        // this is how method of base class is called using child class' object
        //PART 22 
        //Method hiding
        ((Employee)PTE).PrintFullName();
    }
}
