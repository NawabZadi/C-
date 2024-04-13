using System;
public delegate void SampleMethodDelegate();

public delegate int RegisterMethodDelegate();
public delegate void OutParameterDelegate(out int Integer);
public class Program
{
    public static void Main()
    {
        //SampleMethodDelegate del = new SampleMethodDelegate(SampleMethod);
        //del();  //invoking a delegate

        //MULTICAST DELEGATES
        //APPROACH ONE
        SampleMethodDelegate del1, del2, del3, del4; //any instance of this delegate can point to any of the methods

        del1 = new SampleMethodDelegate(SampleMethodOne);    //delegate 1 is pointing to sample method1 and so on
        del2 = new SampleMethodDelegate(SampleMethodTwo);
        del3 = new SampleMethodDelegate(SampleMethodThree);

        del4 = del1 + del2 + del3 - del2; //removing del2  //delegate4 is now pointing to all the three methods
        del4.Invoke();

        //APPROACH 2
        del1 = new SampleMethodDelegate(SampleMethodOne);
        del1 += SampleMethodTwo;
        del1 += SampleMethodThree;

        del1();

        //if delegate has non void return type it will return last method's value

        RegisterMethodDelegate registerMethodDelegate = new RegisterMethodDelegate(RegisterMethodOne);
        registerMethodDelegate += RegisterMethodTwo;

        int ReturnValue = registerMethodDelegate();

        Console.WriteLine("Return value from delegate is {0}", ReturnValue);

        //output parameter
        OutParameterDelegate outParameter = new OutParameterDelegate(OutParameterOne);
        outParameter += OutParameterTwo;

        int outparamterintegervalue = 1;

        outParameter(out outparamterintegervalue);

        Console.WriteLine("Return value from output parameter delegate is {0}", outparamterintegervalue);
    }
    public static void SampleMethodOne(){
        Console.WriteLine("Sample method One invoked");
    }
    public static void SampleMethodTwo(){
        Console.WriteLine("Sample method Two invoked");
    }
    public static void SampleMethodThree(){
        Console.WriteLine("Sample method Three invoked");
    }
    public static int RegisterMethodOne(){
        return 1;    
    }
    public static int RegisterMethodTwo(){
        return 2;    
    }
    public static void OutParameterOne(out int Number)
    {
        Number = 10;
    }
    public static void OutParameterTwo(out int Number)
    {
        Number = 20;
    }
}