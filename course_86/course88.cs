using System;
using System.Threading;
namespace ThreadStartDelegateExample
{
    class Program
    {
        public static void Main()
        {
            //threads
            Thread T1 = new Thread(Number.PrintNumbers);

            //delegate
            Thread T2 = new Thread(delegate() { Number.PrintNumbers(); });

            //lambda Expression
            Thread T3 = new Thread(() => Number.PrintNumbers());


            T1.Start();
        }
    }

    class Number
    {
        
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}