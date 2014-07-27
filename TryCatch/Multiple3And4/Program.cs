using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple3And4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the sum of all the multiples of 3 or 5 below 1000 is :");
            Console.WriteLine(Enumerable.Range(1, 1000).Where(x => x % 3 == 0 && x % 4 == 0).Sum());
            Console.ReadLine();
        }
    }
}
