using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Program
{
    public static void Main()
    {
        // Create a Dictionary, CustomerID is the key. Type is int
        // Customer object is the value. Type is Customer
        Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

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

        // Add customer objects to the dictionary
        dictionaryCustomers.Add(customr1.ID, customr1);
        dictionaryCustomers.Add(customr2.ID, customr2);
        dictionaryCustomers.Add(customr3.ID, customr3);

        Customer customer;
        if(dictionaryCustomers.TryGetValue(101, out customer))
        {
            Console.WriteLine("ID={0}, name={1}, Salry={2}",customer.ID, customer.Name,customer.Salary);
        }
        else
        {
            Console.WriteLine("key not found");
        }
        Console.WriteLine("Total number of objects = {0}", dictionaryCustomers.Count());
        Console.WriteLine("Total number of objects = {0}", dictionaryCustomers.Count(kvp => kvp.Value.Salary > 5000));

        dictionaryCustomers.Remove(101);
        Console.WriteLine("\nAfter removing object with key=101: ");
        Console.WriteLine("Total number of objects = {0}", dictionaryCustomers.Count());

        dictionaryCustomers.Clear();
        Console.WriteLine("\nAfter clearing all items : ");
        Console.WriteLine("Is the dictionary empty? {0} ", !dictionaryCustomers.Any());
    }
public class Customer
    {
        public int ID {get; set;}
        public string Name{get; set;}
        public int Salary{get; set;}
    }
}