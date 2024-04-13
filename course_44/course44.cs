using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        //exception handling abuse prevention
        try
        {
            Console.WriteLine("Enter Numerator");
            int Numerator;
            bool IsNumeratorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Numerator);
            if(IsNumeratorConversionSuccessfull)
            {
                 Console.WriteLine("Enter Denominator");
                 int Denominator;
                 bool IsDenominatorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Denominator);
                 if(IsDenominatorConversionSuccessfull)
                 {
                    int Result = Numerator / Denominator;            
                     Console.WriteLine("Result is {0}", Result);  
                 }
                 else
                 {
                    if(Denominator==0)
                    {
                        Console.WriteLine("Divide by zero is not possible");
                    }
                    else{
                        Console.WriteLine("Denominator should between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
                    }
                 }
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }

           

        } 
         catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }  
    }
}