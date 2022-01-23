using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using System.Threading;



namespace Multithreading_Sample
{
    class Printer
    {
        private object lockTocken = new object();



        public void PrintNumbers()
        {
            lock (lockTocken)
            {
                Console.WriteLine("Thread-> {0} started @{1} and executing PrintNumbers() method",
                Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToLongTimeString());



                Console.Write("Your numbers:");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("{0} ,", i);
                    Thread.Sleep(1000);



                }
                Console.WriteLine();
            }
        }
    }
}
