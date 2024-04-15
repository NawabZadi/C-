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
        Stack<Customer> stack = new Stack<Customer>();
        stack.Push(customr1);
        stack.Push(customr2);
        stack.Push(customr3);

        // Customer c1 = stack.Pop(); //pop will remove top of the stack item and return the item
        // Console.WriteLine(c1.Name + "-" + c1.ID);
        // Console.WriteLine("Total no of items in stack: " + stack.Count);

        Customer c1 = stack.Peek(); //peek will return top of the stack item without removing it
        Console.WriteLine(c1.Name + "-" + c1.ID);
        Console.WriteLine("Total no of items in stack: " + stack.Count);

    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    }
