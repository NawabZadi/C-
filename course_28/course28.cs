public class Program
{
    //STRUCTS
    public static void Main()
    {
        Customer C1 = new Customer(11, "Amina");
        C1.printDetails();

        //working with properties
        Customer C2 = new Customer();
        C2._id = 10;
        C2.Name = "Ibrar";
        C2.printDetails();

        //working with default struct
        Customer C3 = new Customer
        {
            _id = 120,
            Name = "Zainab"
        };
        C3.printDetails();

    }
}
public struct Customer
{
    private string name;
    private int id;

    public int _id{
        set{
            this.id = value;
        }
        get{
            return this.id;
        }
    }

    public string Name {
         get => name; set => name = value; 
         }
    public Customer(int ID, string Name){
        this.id = ID;
        this.name = Name;
    }     
    public void printDetails(){
        Console.WriteLine("id: " + this.id + " " + "name is: " + this.name);
    }
}
