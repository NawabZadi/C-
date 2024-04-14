using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
public class namedParameter
{
    public static void Main()
    {
        AddNumbers(10, 20);
    }
    public static void AddNumbers(int firstNumber, int secondNumber, [OptionalAttribute] int[] restOfTheNumbers)
    {
        int result = firstNumber + secondNumber;
        // loop thru restOfTheNumbers only if it is not null
        // otherwise you will get a null reference exception
        if (restOfTheNumbers != null)
        {
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
        }      

         Console.WriteLine("Total = " + result.ToString());
    }
}