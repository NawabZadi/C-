using System;
using System.Reflection;
namespace Amina
{
    public class mainClass
    {
        //overriding ToString method
        private static void Main()
        {
            //int i = 10;
            //int j = 10;
            //Console.WriteLine(i == j);
            //Console.WriteLine(i.Equals(j));

            Name name = new Name();
            name.firstname = "Amina";
            name.secondname = "fayyaz";

            Name name0 = name;
            Console.WriteLine(name == name0);   //true b/c of value type
            Console.WriteLine(name.Equals(name0)); //true



            Name name1 = new Name();
            name1.firstname = "Amina";
            name1.secondname = "fayyaz";

            //two d/f object of same class
            //ValueType is same but referencetype is d/f
            //so we'll override 'Equals' method
            Console.WriteLine(name == name1); //reference equality
            Console.WriteLine(name.Equals(name1)); //value equality  //now its true because value type is same
        }
    }
    public class Name
    {
        public string firstname { get; set; }
        public string secondname { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!(obj is Name))
            {
                return false;
            }
            return this.firstname == ((Name)obj).firstname && this.secondname == ((Name)obj).secondname;
        }
        public override int GetHashCode()
        {
            return this.firstname.GetHashCode() ^ /*and->^*/ this.secondname.GetHashCode();
        }
    }
}