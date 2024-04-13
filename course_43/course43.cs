using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        //exception handling abuse
        try
        {
            Console.WriteLine("Enter first number");
            int FN  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int SN  = Convert.ToInt32(Console.ReadLine());

            int Result = FN / SN;            
            Console.WriteLine("Result is {0}", Result);

        }
        catch(FormatException)
        {
            Console.WriteLine("Enter valid number");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Only numbers between {0} and {1} are allowed", Int32.MinValue, Int32.MaxValue);
        }
        catch(DivideByZeroException)
        {
            Console.WriteLine("Divide by zero is not possible");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}