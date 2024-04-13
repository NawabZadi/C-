public class Employee
{
    //POLYMORPHISM
    public string FirstName = "Amina";
    public string LastName = "Fayyaz";

    public virtual void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " ");
    }
}
public class PartTimeEmployee : Employee
{
     public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " " + " part time");
    }
}   
public class FullTimeEmployee : Employee
{
     public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " " + " full time");
    }
}  
public class TemporaryEmployee : Employee
{
     public override void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName + " " + " temporary employee");
    }
}  
public class course23
{
    private static void Main()
    {
        Employee[] employee = new Employee[4];
        employee[0] = new Employee();
        employee[1] = new PartTimeEmployee();
        employee[2] = new FullTimeEmployee();
        employee[3] = new TemporaryEmployee();

        foreach(Employee e in employee){
            e.PrintFullName();
        }
    }
}