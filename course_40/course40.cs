using System;
using System.IO;
public class Program
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            //Exception Handling
            streamReader = new StreamReader(@"C:\C#\exception.txt");
            Console.WriteLine(streamReader.ReadToEnd()); //read file to the end
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine(ex.StackTrace);  //shows which LOC throws exception
        }
        finally
        {
            streamReader.Close(); //close the file
            Console.WriteLine("Closing the file");
        }
        
    }
}