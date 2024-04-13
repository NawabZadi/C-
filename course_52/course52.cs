using System;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args)
    {
        Calculator.Add(10,20);
    }
}
class Calculator
{
    //attribute used for declerative information for developer it gives compiler warnings
    [Obsolete("Use ADD<List> method")]
    public static int Add(int FN, int SN)
    {
        return FN + SN;
    }
    public static int ADD(List<int> Numbers)
    {
        int Sum = 0;
        foreach(int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }
}