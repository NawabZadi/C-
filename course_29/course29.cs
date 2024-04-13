public class Customer
{
    public int ID{
        set;
        get;
    }
    public string name{
        set;
        get;
    }
}
public class course29{
    public static void Main()
    {
        //value types are copied
        //structures
        int i = 10;
        int j = 20;
        j = j + 10;
        Console.WriteLine("i is " + i + " " + "j is " + j);

        Customer C1 = new Customer();
        C1.ID = 11;
        C1.name = "Amina";

        //when you copy refernce types, you only get the copy of reference variable
        //beacuse both of them can be find out on one object i.e., it is saved in heap not stack
        Customer C2 = C1;
        C2.ID = 100;
        C2.name = "Ibrar";

        Console.WriteLine("Id is: " + C1.ID + " " + C2.ID);
    }
}