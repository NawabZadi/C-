using System;
using System.Reflection;
namespace Amina
{
    public class mainClass
    {
        //overriding ToString method
        private static void Main()
        {
            Customer C1 = null;
            //on null object we cannot call reference object
            //string str = C1.ToString(); //throws Null Reference exception
           // Console.WriteLine(str);   

            string str1 = Convert.ToString(C1);  //shows nothing  //handles null
            
            Console.WriteLine(str1);

        }
    }
    public class Customer
    {
        public string name { get; set; }
    }
}