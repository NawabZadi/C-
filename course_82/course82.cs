using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
public class Program
{
    public static void Main()
    {
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
        Queue<Customer> queueCustomer = new Queue<Customer>();
        queueCustomer.Enqueue(customr1);
        queueCustomer.Enqueue(customr2);
        queueCustomer.Enqueue(customr3);

        //Customer c1 = queueCustomer.Dequeue();
        //Console.WriteLine(c1.ID + " " + c1.Name);
        //Console.WriteLine("Total number of items in the queue: {0}" + queueCustomer.Count);

        // foreach(Customer customer in queueCustomer)
        // {
        //    Console.WriteLine(customer.Name + "-" + customer.ID);
        //     Console.WriteLine("Total number of items in the queue: " + queueCustomer.Count);
        // }
        Customer c2 = queueCustomer.Peek();        
        Console.WriteLine(c2.ID + " " + c2.Name);

    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    }
