using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        List<Customer> customers = new List<Customer>(2);
        customers.Add(customr1);
        customers.Add(customr2);
        customers.Add(customr3);

        Console.WriteLine("Customers before sorting");
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.ID);
        }

        // Approach 1
        // Step 2: Create an instance of Comparison delegate
        //Comparison<Customer> customerComparer = 
        //    new Comparison<Customer>(CompareCustomers);

        // Step 3: Pass the delegate instance to the Sort method
        //customers.Sort(customerComparer);

        // Approach 2: Using delegate keyword
        //customers.Sort(delegate(Customer c1, Customer c2)
        //{
        //    return (c1.ID.CompareTo(c2.ID));
        //});

        // Aaproach 3: Using lambda expression
        customers.Sort((x, y) => x.ID.CompareTo(y.ID));

        Console.WriteLine("Customers after sorting by ID");
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.ID);
        }

        customers.Reverse();
        Console.WriteLine("Customers in descending order of ID");
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.ID);
        }
    }

    // Approach 1 - Step 1
    // Method that contains the logic to compare customers
    private static int CompareCustomers(Customer c1, Customer c2)
    {
        return c1.ID.CompareTo(c2.ID);
    }
}
public class Customer { 
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

}
