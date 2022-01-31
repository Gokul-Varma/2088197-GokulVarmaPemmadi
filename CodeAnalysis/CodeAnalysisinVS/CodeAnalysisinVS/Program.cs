using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAnalysisinVS
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "john", "Boby", "Charig", "Denis", "Alfee", "Bond" };

            var namesOFB = names.Where(n => n.StartsWith("B"));
        }
    }
}
