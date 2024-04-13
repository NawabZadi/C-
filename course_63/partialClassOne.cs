partial class SampleClass
{
    // Declaration of the partial method.
    partial void SampleMethod(); //must be declared/defined
    //must have no access modifier
    //private by default
    //partial methods can only be implemented once
    //partial method must be declared within partial class/partial struct


    partial void SampleMethod()
    {
         Console.WriteLine("Sample Method Invoked");
    }

    // A public method calling the partial method
    public void PublicMethod()
    {
        Console.WriteLine("Public Method Invoked");
        SampleMethod();
    }
}