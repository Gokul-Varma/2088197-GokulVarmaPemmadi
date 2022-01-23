using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartSample
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine($"-> {Thread.CurrentThread.Name} is executing PrintNumbers()");

            Console.WriteLine("Your numbers: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}, ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }
}
