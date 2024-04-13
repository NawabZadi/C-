public class Program
{
    public static void Main ()
    {
        //enums
        //strongly typed constant
        //increment from zero
        //has methods like getname get type etc

        short[] Values = (short[])Enum.GetValues(typeof(Gender));
        foreach (short vlaues in Values)
        {
            Console.WriteLine(vlaues);  //enum been converted to integers 
        }
        string[] names = Enum.GetNames(typeof(Gender));
        foreach (string Names in names)
        {
            Console.WriteLine(Names);  //enum been converted to string the name they hold
        }
    }
}
//enum -> a user definrd datatype used to define a set of d/f values with distinct values
public enum Gender : short  //can specify the type you want to switch to
{ 
    unknown = 1, ///customize this value
    male = 41,
    female
}