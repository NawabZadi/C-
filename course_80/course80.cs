using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
public class Program
{
    public static void Main()
    {
        // Create Customer Objects
        Customer customr1 = new Customer()
        {
            ID = 101,
            Name = "Mark",
            Salary = 5000
        };

        Customer customr2 = new Customer()
        {
            ID = 102,
            Name = "Pam",
            Salary = 7000
        };

        Customer customr3 = new Customer()
        {
            ID = 104,
            Name = "Rob",
            Salary = 5500
        };

        List<Customer> customers = new List<Customer>(100);
        customers.Add(customr1);
        customers.Add(customr2);
        customers.Add(customr3);

        //readonly will allow to add only view and retrieve not add and remove functions
        ReadOnlyCollection<Customer> readonlyCustomers =  customers.AsReadOnly();
        Console.WriteLine("Items : " +  readonlyCustomers.Count);

        //checks whole list and if whole list comes under the condition it returns true otherwise false
        Console.WriteLine("Are all the customers salary greater than 5000 = " + customers.TrueForAll(x => x.Salary > 5000));

        // listCutomers list is created with an initial capacity of 100
        // but only 3 items are in the list. The filled percentage is 
        // less than 90 percent threshold.
        Console.WriteLine("List capacity before invoking TrimExcess = " + customers.Capacity);
        // Invoke TrimExcess() to set the capacity to the actual 
        // number of elements in the List
        customers.TrimExcess();
        Console.WriteLine("List capacity after invoking TrimExcess = " + customers.Capacity);
}
public class Customer { 
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

}
}
