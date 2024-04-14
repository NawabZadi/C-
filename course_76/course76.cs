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
        
        if(customers.Contains(customr3))
        {
            Console.WriteLine("Custonmer 3 exists in the list");
        }
        else
        {
            Console.WriteLine("Custonmer 3 does not exists in the list");
        }
        
        
        if (customers.Exists(cust=>cust.Name.StartsWith("R")))
        {
            Console.WriteLine("R name is in the list");
        }
        else
        {
            Console.WriteLine("R name is not in the list");
        }

        Customer c = customers.Find(customers=>customers.Salary>5000);
        Console.WriteLine($"The customer who has salary more than 5000 is: {c.Name} with id {c.ID} and salary {c.Salary}");
        

        // FindAll() method returns all the items from the list that
        // match the conditions specified by the lambda expression
        List<Customer> filteredCustomers = customers.FindAll(customer => customer.Salary > 5000);
        foreach (Customer cstmr in filteredCustomers)
        {   
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.ID, cstmr.Name, cstmr.Salary);
        }       
    }
public class Customer
    {
        public int ID {get; set;}
        public string Name{get; set;}
        public int Salary{get; set;}
    }
}