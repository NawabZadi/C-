using System;
using System.Text;
namespace Amina
{
    public class Amina_Fayyaz
    {
        private static void Main(string[] args)
        {
            //string creates object in heap as i the i am then i am amina then i am Amina fayyaz
            //it will create many objects and its value cannot be changes i.e., immutable
            string useString = "I";
            useString += " am";
            useString += " Amina";
            useString += " Fayyaz";

            Console.WriteLine(useString); //shows strin

            //stringBuilder
            //will create only one object
            //is mutable
            StringBuilder s = new StringBuilder("I");
            s.Append(" am");
            s.Append(" Amina");
            s.Append(" Fayyaz");
            Console.WriteLine(s.ToString());
        }
    }
}