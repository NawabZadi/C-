using System;
using System.Reflection;
namespace Amina
{
    public class mainClass
    {
        //Generics
        private static void Main()
        {
            bool equal = Calculator.AreEqual(10, 90);  //so there is a conversion from value type (int) to reference type(object) which is called unboxing
            //and there is unnecessary boxing present

            //another problem is if user want to compare int with string which doesn't make sense, compiler will allow him to do so
            //equal = Calculator.Equals(10, "iu");  //doesn't show any error
            //the method is not strongly typed
            //to solve this problem we use generics
            //make the method independent of the type it operates on-> allow by generics


            //<int> won't allow any other type than int
            equal = Calculator<int>.AreEqual/*<int>*/(10, 10);
            if(equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    //we can make class as generic so its all methods can be reused by any type
    public class Calculator<T>
    {
        //we added generics so the comparison type must be same
        //resolve unnecesary boxing and unboxing
        //generics help to use code with any type
        public static bool AreEqual/*<T>*/(T Num1, T Num2) //now same problem
        {
            return Num1.Equals(Num2);
        }
    }
}