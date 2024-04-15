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

        //we want to sort objects now how to do that
        //we use IComparable inerface
        //because dotnet doesn't know on which criteria should it sort
        //should it sort based on ID, Name or Salary
        Console.WriteLine("Before sorting");
        foreach(Customer c in customers)
        {
            Console.WriteLine(c.Salary);
        }

        //sort
        customers.Sort();

        Console.WriteLine("After sorting");
        foreach(Customer c in customers)
        {
            Console.WriteLine(c.Salary);
        }

        //sort by name of customers
        // To sort customers by name instead of salary
        SortByName sortByName = new SortByName();
        customers.Sort(sortByName);

        Console.WriteLine("Customers after sorting by Name");
        foreach (Customer customer in customers)
        {
            Console.WriteLine(customer.Name);
        }
    }
public class Customer : IComparable<Customer>
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }

    public int CompareTo(Customer obj)//type T is customer here
    {
        // if (this.Salary > obj.Salary)
        //    return 1;
        // else if (this.Salary < obj.Salary)
        //    return -1;
        // else
        //    return 0;

        // OR, Alternatively you can also invoke CompareTo() method. 
        return this.Salary.CompareTo(obj.Salary);
    }
}
public class SortByName : IComparer<Customer>
{
    public int Compare(Customer x, Customer y)
    {
        return x.Name.CompareTo(y.Name);
    }
}
}