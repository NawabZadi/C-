using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class methodOverloading
{
    public static void Main()
    {
        //AddNumbers(10, 90, 89, 88, 90); // Calling the method with more than required parameters
        //AddNumbers(10,20); //will require third integer so we call it as null
        //If I want to add 3 or more numbers, then I can use the overloaded version of AddNumbers() function
        AddNumbers(10, 90, new int[] {1, 2, 3, 4, 5});
    }
    //2. method overloading
    //if user passes only 2 numbers
    public static void AddNumbers(int firstNumber, int secondNumber)
    {
        AddNumbers(firstNumber, secondNumber, null);
    }
    //params should be at last
    public static void AddNumbers(int firstNumber, int secondNumber, int[] restOfTheNumbers)
    {
        int result = firstNumber + secondNumber;
        foreach (int i in restOfTheNumbers)
        {
              result += i;
        }       

    Console.WriteLine("Total = " + result.ToString());
    }
}