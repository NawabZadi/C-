//this class should provide implementation for abstact class methods
//if you don't want to just make this class abstract class
public class Program: customer1
{
    //abstarct class

    public static void Main()
    {
       Program p = new Program();
       p.print();

       customer1 c1 = new Program();
       c1.print();
    }
    public override void print()
    {
        Console.WriteLine("print method");
    }
}
//abstract class cannot instanciated but can be used as a base class for other classes
//an abstract class may contain abstract members but not mendatory
public abstract class customer1{
    public abstract void print();
}

public abstract class customer2{
    public void print(){
        Console.WriteLine("Customer2 abstact class' method");
    }
}