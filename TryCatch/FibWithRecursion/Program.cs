using System;
using System.Collections.Generic;
using System.Linq;

namespace FibWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib fibonacci = new Fib();
            Console.WriteLine("Ten first elements in fibonacci sequence:");
            int index = 0;
            List<int> list = new List<int>(){
                    1
                };
            List<int> result = fibonacci.getFib(list, index);
            result.ForEach(x => Console.WriteLine(x));
            Console.ReadLine();
        }
    }

    public class Fib
    {
        public List<int> getFib(List<int> fib, int index)
        {
            if(fib[index] > 100)
                return fib.Take(10).ToList();
            fib.Add(fib[index] + (index - 1 < 0 ? fib[0] : fib[index - 1]));
            index++;
            return getFib(fib, index);
        }
    }
}
