public class Program
{
    public static void Main ()
    {
        //enums
        //strongly typed constant
        Customer[] customer = new Customer[3];
        customer[0] = new Customer
        {
            name = "Amina",
            Gender = 2
        };
        customer[1] = new Customer
        {
            name = "Mary",
            Gender = 1
        };
        customer[2] = new Customer
        {
            name = "Sam",
            Gender = 0
        };
        foreach (Customer c in customer)
        {
            Console.WriteLine("Name is {0} and gender is {1}", c.name, Getgender(c.Gender));
        }

    }
    public static string Getgender(int Gender){
        switch (Gender)
        {
            case 0:
                return "unknown";
            case 1:
                return "male";
            case 2:
                return "female";        
            default:
                return "Invalid Data";
        }
    }
}
// 0->unknown
// 1->male
// 2->female
public class Customer
{
    public string name {get; set;}
    public int Gender {get; set;}
}