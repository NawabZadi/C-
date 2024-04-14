public class Program
{
    public static void Main()
    {
        //outinterfaces
        OutInterface opf = new OutInterface();
        //now there is an abmiguity that which method of interface has been called
        //so to remove this ambiguity we use explicit implementation
        ((Iinterface1)opf).print();
        ((Iinterface2)opf).print();
        //opf.print();

        //another method
        Iinterface1 iinterface1 = new OutInterface();
        iinterface1.print();


        //default implementation just add public access modifier to print method
        opf.print();  //will call print 3 method
    }

}
interface Iinterface1
{
    void print();
}
interface Iinterface2
{
    void print();
}
interface Iinterface3 : Iinterface2
{
    void print();
}
class OutInterface : Iinterface1 , Iinterface2
{
    void Iinterface1.print()//explicit implementation
    {
        //signature should be same
        Console.WriteLine("Interface print1 method");
    }
   void Iinterface2.print()
    {
        //signature should be same
        Console.WriteLine("Interface print2 method");
    }
    public void print()
    {
        Console.WriteLine("Interface print3 method");
    }
}