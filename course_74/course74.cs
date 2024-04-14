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
        //copy from customer at 0 index to customer3
        customers.Insert(0, customr3);
        Console.WriteLine("Indexofcustomer3 = {0}", customers.IndexOf(customr3));
        foreach(Customer c in customers)
        {
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
        }
        
    }
public class Customer
    {
        public int ID {get; set;}
        public string Name{get; set;}
        public int Salary{get; set;}
    }
}