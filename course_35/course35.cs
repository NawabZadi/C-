public class Program
{
    //multiple class inheritance using interfaces
    public static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}
interface IA
{
    void AMethod();
}
class A : IA
    {
        public void AMethod()
        {
            Console.WriteLine("A");
        }
    }
interface IB
{
   void BMethod();
}
 class B : IB
    {
        public void BMethod()
        {
            Console.WriteLine("B");
        }
    }
class AB : IA, IB //since a class cannot be derived from multiple classes we'll use interfaces
{
    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
}