public class Program
{
    public static void Main()
    {
        formalCustomers FC1 = new formalCustomers();
        FC1.print1();
        FC1.print2(); 
        FC1.print3();   

        //cannot have object of an interface
        //ICustomer1 IC1 = new ICustomer1(); 
        ICustomer2 customer1 = new formalCustomers();   //allowed as Icutomer2 is a parent class of formalCustomer class
        customer1.print2(); 
    }
}
class formalCustomers : ICustomer2, ICustomer3 //class can be derived from many interfaces 
{
    //all methods of interface must be implemented inside class
    public void print1()
    {
        //signature should be same
        Console.WriteLine("Interface print1 method");
    }
    public void print2()
    {
        //signature should be same
        Console.WriteLine("Interface print2 method");
    }
    public void print3()
    {
        //signature should be same
        Console.WriteLine("Interface print3 method");
    }

}
//interfaces-> public by default
//no implementation no fields no definations just declarations
//just like abstract class
interface ICustomer1  
{
    //interface methods cant have access modifiers
    void print1();
    //int id;   ->  error CS0525: Interfaces cannot contain instance fields
}
interface ICustomer2 
{
    //interface methods cant have access modifiers
    void print2();
    //int id;   ->  error CS0525: Interfaces cannot contain instance fields
}
interface ICustomer3 : ICustomer2 
{
    //interface methods cant have access modifiers
    void print3();
    //int id;   ->  error CS0525: Interfaces cannot contain instance fields
}