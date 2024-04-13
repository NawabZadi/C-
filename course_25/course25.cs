public class Program
{
    //Method overrriding
    public static void Main()
    {
        Add(4,2);
        Add(10, 12);
        Add(1, 2, 3);
        Add(1, 1, 1);

    }
    //we can call same method name with d/f parameter
    public static void Add(int FN, int SN){
        Console.WriteLine(FN+SN);
    }
    public static void Add(int FN, int SN, int TN){
        Console.WriteLine(FN+SN+TN);
    }
    //we cannot overload a method with d/f return type
    // it cannot happen to pass output parameter or keyword params it will give error
    // public static int Add(int FN, int SN, int TN, out int Sum){
    //     Sum = FN+SN+TN;
    //     Console.WriteLine("Sum is: {0}", Sum);
    // }
}