using System;
using System.Reflection;
namespace Amina
{
    public class mainClass
    {
        //late binding
        private static void Main()
        {
            //if information on the type is not avalaible at compile time we use late binding otherwise we use early binding
            //1.load the assembly
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //2.get the type 
            Type customerType = executingAssembly.GetType("Amina.Customer");

            //3.create an instance of the class
            //if its static this step is not necessary
            object customerInstance = Activator.CreateInstance(customerType);

            //4.get the method
            MethodInfo customerMethod = customerType.GetMethod("GetFullName");   //customner.method("NAME");

            //5.pass the parameters to the method
            string[] customerName = new string[2];
            customerName[0] = "Amina";
            customerName[1] = "Fayyaz";

            //6.invoke the method
            string fullName = (string)customerMethod.Invoke(customerInstance, customerName);
            Console.WriteLine("Full Name {0}", fullName);

            //Early Binding
            //Customer customer = new Customer();
            //string FullName = customer.GetFullName("Amina", "Fayyaz");
            //Console.WriteLine("Full Name {0}", FullName);
        }
    }
    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}