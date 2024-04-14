using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class namedParameter
{
    public static void Main()
    {
        Test(1, 2, 3);

        //if we want to give 2 to we will be using named parameter
        Test(1, c : 2);
    }
    public static void Test(int a, int b = 10, int c = 20)
    {
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
    }
}