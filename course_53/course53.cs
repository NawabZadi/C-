using System;
using System.Collections.Generic;
using System.Reflection;
namespace Amina
{
    //Reflection
    public class Program
{
    public static void Main(string[] args)
    {
        //basic info
        Type type = Type.GetType("Amina.Customer");
        Console.WriteLine("FULL NAme: {0}", type.FullName);
        Console.WriteLine("JUST NAme: {0}", type.Name);
        Console.WriteLine("Namespace: {0}", type.Namespace);
        Console.WriteLine();

        //properties
        Console.WriteLine("Properties in Customer");
        PropertyInfo[] properties = type.GetProperties();
        foreach(PropertyInfo property in properties)
        {
            Console.WriteLine(property.PropertyType.Name + " " + property.Name);
        }
        //methods in customer
        Console.WriteLine();
        Console.WriteLine("Methods in Customer Class");
        MethodInfo[] methods = type.GetMethods();
        foreach(MethodInfo method in methods)
        {
            Console.WriteLine(method.ReturnType.Name + " " + method.Name);
        } 
        Console.WriteLine();
        Console.WriteLine("Constructors in Customer Class");
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach(ConstructorInfo constructor in constructors)
        {
            Console.WriteLine(constructor.ToString());
        }

    }
}

public class Customer
{
    public int? ID{get; set;}
    public string? Name{get; set;}

    public Customer()
    {

    }
    public Customer(int id, string name)
    {
            this.ID = id;
    } 
    public void printmethod()
    {

    }
    public void printmethod1()
    {

    }
}
}
