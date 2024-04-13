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
            Gender = Gender.female
        };
        customer[1] = new Customer
        {
            name = "Mary",
            Gender = Gender.male
        };
        customer[2] = new Customer
        {
            name = "Sam",
            Gender = Gender.unknown
        };
        foreach (Customer c in customer)
        {
            Console.WriteLine("Name is {0} and gender is {1}", c.name, Getgender(c.Gender));
        }

    }
    //for readability whats 0 now readable unknown
    public static string Getgender(Gender Gender){
        switch (Gender)
        {
            case Gender.unknown:
                return "unknown";
            case Gender.male:
                return "male";
            case Gender.female:
                return "female";        
            default:
                return "Invalid Data";
        }
    }
}
public enum Gender
{
    unknown,
    male,
    female
}
// 0->unknown
// 1->male
// 2->female
public class Customer
{
    public string name {get; set;}
    public Gender Gender {get; set;}
}