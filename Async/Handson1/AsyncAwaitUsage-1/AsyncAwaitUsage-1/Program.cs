using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwaitUsage_1
{
    public class Program
    {
        static async Task  Main(string[] args)
        {
            await Method1();
           // Console.WriteLine("after the method1 fully completed ");

        }
        static async Task  Method1()
        {
            string str = await Method2();
            Console.WriteLine(str); 
         //   Console.WriteLine("method 1 completd");
        }
        static async Task <string> Method2()

        {
            Thread.Sleep(2000);
            return "method2 displayed";

        }
    }
}
