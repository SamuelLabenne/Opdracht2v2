using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Koe koe = new Koe(12);
            Console.WriteLine(koe.ToString());
            Slang slang = new Slang(12);
            Console.WriteLine(slang.ToString());
            Varken varken = new Varken(120);
            Console.WriteLine(varken.ToString());
        }
    }
}
