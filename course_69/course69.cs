using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class optionalParameter
{
    public static void Main()
    {
        AddNumbers(10, 90, 89, 88, 90); // Calling the method with more than required parameters
    }
    //params should be at last
    public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfTheNumbers)
    {
        int result = firstNumber + secondNumber;
        foreach (int i in restOfTheNumbers)
        {
              result += i;
        }       

    Console.WriteLine("Total = " + result.ToString());
    }
}