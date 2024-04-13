using System;
using System.IO;
public class Program
{
    public static void Main() 
    {
    try{

        
        try
        {
            Console.WriteLine("Enter first number");
            int FN  = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int SN  = Convert.ToInt32(Console.ReadLine());

            int Result = FN / SN;            
            Console.WriteLine("Result is {0}", Result);

        }
        catch(Exception ex)
        {
            string filePath = @"C:\C#\long.txt";

            if(File.Exists(filePath))
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.Write(ex.GetType().Name); //writes error in specified file
                sw.WriteLine();
                sw.WriteLine(ex.Message);
                sw.Close();
                Console.WriteLine("An error occured please try again later");
            }
            else
            {
                throw new FileNotFoundException(filePath + " is not present", ex);
            }
            
        }
    }
    catch(Exception exc)
    {
        Console.WriteLine("Current Exception = {0}", exc.GetType().Name);
        Console.WriteLine("Inner Exception = {0}", exc.InnerException.GetType().Name);
    }
    }

    
}