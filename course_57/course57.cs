using System;
using System.Reflection;
namespace Amina
{
    public class mainClass
    {
        //overriding ToString method
        private static void Main()
        {
            int number = 10;
            Console.WriteLine(number.ToString());

            Name name = new Name();
            name.firstname = "Amina";
            name.secondname = "fayyaz";

            Console.WriteLine(name.ToString());
            Console.WriteLine(Convert.ToString(name));
        }
    }
    public class Name
    {
        public string firstname { get; set; }
        public string secondname { get; set; }

        public override string ToString()
        {
            return this.firstname + ", " + this.secondname ;
        }
    }
}