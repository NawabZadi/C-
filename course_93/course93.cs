using System;
using System.Threading;
class Program
{
    static int Total = 0;
    public static void Main()
    {
        // AddOneMillion();
        // AddOneMillion();
        // AddOneMillion();
        // Console.WriteLine("Total = " + Total);
        
        //Stopwatch stopwatch = Stopwatch.StartNew();

        Thread thread1 = new Thread(Program.AddOneMillion);
        Thread thread2 = new Thread(Program.AddOneMillion);
        Thread thread3 = new Thread(Program.AddOneMillion);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Total = " + Total);

        // stopwatch.Stop();
        // Console.WriteLine("Time Taken in Ticks = " + stopwatch.ElapsedTicks);
    }
    //static object _lock = new object();

    public static void AddOneMillion()
    {
        for (int i = 1; i <= 1000000; i++)
        {
        //     lock (_lock)
        // {
        //     Total++;
        // }
            Interlocked.Increment(ref Total);
            //The Interlocked.Increment() Method, increments a specified variable and stores the result, as an atomic operation
        }
    }
}