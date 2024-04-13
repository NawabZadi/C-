public delegate void HelloFromDelegate(string Messgaae);
public class Program
{
    public static void Main ()
    {
        //delegates
        //A delegate is a type safe function pointer 
        //type safe means that signature of method and delegate must be same
        HelloFromDelegate he = new HelloFromDelegate(Hello);
        he("hello from Delegate");
    }
    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }

}